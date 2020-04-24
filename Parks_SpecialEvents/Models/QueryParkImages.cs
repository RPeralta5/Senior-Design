using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Parks_SpecialEvents.Models
{
    public class QueryParkImages
    {

        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IConfiguration _config;

        public QueryParkImages()
        {
        }

        public QueryParkImages(IConfiguration config)
        {
            _config = config;
        }

        public QueryParkImages(IHostingEnvironment e, IConfiguration config)
        {
            hostingEnvironment = e;
            _config = config;
        }

        private string PARK_DB_CONNECTION
        {
            get { return _config.GetValue<string>("ConnectionString:default"); }
        }

        private void DeleteImageFromAzure(string imagePath)
        {
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "DELETE FROM ParkImages" + 
                        $" WHERE ImagePath = '{imagePath}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // delete image from database
                sqlCommand.ExecuteNonQuery();

                // close connection
                sqlConnection.Close();
            }
        }

        public void DeleteImagesFor(string parkID, List<string> imagesToKeep)
        {
            List<string> allImages = getImagesPath(parkID);
            foreach(string image in allImages)
            {
                if(!imagesToKeep.Contains(image))
                {
                    // get image web path
                    string imageWebPath = Path.Combine(hostingEnvironment.WebRootPath + image);
                    // delete image
                    File.Delete(imageWebPath);
                    DeleteImageFromAzure(image);
                }
            }
        }

        public List<Image> getImages(string parkID)
        {
            List<Image> images = new List<Image>();

            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT * FROM ParkImages" +
                    $" WHERE ParkID = '{parkID}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Image i = new Image();
                        i.ImageID = (int)reader[0];
                        i.ParkID = (string)reader[1];
                        i.ImagePath = (string)reader[2];
                        images.Add(i);
                    }
                }

                // close connection
                sqlConnection.Close();
            }
        
            return images;
        }

        public List<string> getImagesPath(string parkID)
        {
            List<string> images = new List<string>();

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT ImagePath FROM ParkImages" + 
                    $" WHERE ParkID = '{parkID}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string path = Path.Combine(hostingEnvironment.WebRootPath, (string)reader[0]);
                        images.Add(path);
                    }
                }

                // close connection
                sqlConnection.Close();
            }
            
            return images;
        }

        public string generateNewParkFolderFor(string parkLastName)
        {
            return parkLastName.Replace(" ", "");
        }

        public string generateParkFolderFor(string parkID)
        {
            string parkFolder = "";
            // get park name
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT ParkLastName FROM Parks" +
                    $" WHERE ParkID = '{parkID}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // get park name
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        parkFolder += (string)reader[0];
                    }
                }

                // close connection
                sqlConnection.Close();
            }
            parkFolder = parkFolder.Replace(" ", ""); // takes out empty space
            return parkFolder;
        }

        public void AddImages(AzureParkImages park)
        {
            string query = "INSERT INTO ParkImages(ParkID, ImagePath)";          

            // IF NO IMAGES WERE ADDED : DON'T DO THIS STEP
            if(park.Images.Count != 0)
            {
                
                int counter = 0;

                // generate folder path
                string parkFolder = generateParkFolderFor(park.ParkID);                
            
                // create directory for park images
                string pathString = Path.Combine(hostingEnvironment.WebRootPath + "/images/", $"{parkFolder}");
                Directory.CreateDirectory(pathString);              

                foreach (IFormFile image in park.Images)
                {            
                    // GET DESTINATION PATH OF WHERE THE IMAGE IS GOING TO BE PLACED
                    var destinationFile = Path.Combine(hostingEnvironment.WebRootPath + $"/images/{parkFolder}", Path.GetFileName(image.FileName));

                    //PASTE IMAGE THERE
                    image.CopyTo(new FileStream(destinationFile, FileMode.Create));

                    counter++;
                    if(park.Images.Count == 1)
                    {
                        query += "VALUES " +
                                $"('{park.ParkID}', '/images/{parkFolder}/{image.FileName}');";
                    } else
                    {
                        if(counter == 1)
                        {
                            query += "VALUES " +
                                $"('{park.ParkID}', '/images/{parkFolder}/{image.FileName}'),";
                        } else
                        {
                            if(counter == park.Images.Count)
                            {
                                query += $" ('{park.ParkID}', '/images/{parkFolder}/{image.FileName}');";
                            } else
                            {
                                query += $" ('{park.ParkID}', '/images/{parkFolder}/{image.FileName}'),";
                            }
                        }
                    }

                }
                
                using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    // open connection
                    sqlConnection.Open();

                    // add images to park
                    sqlCommand.ExecuteNonQuery(); // used to be executeReader

                    // close connection
                    sqlConnection.Close();
                }
            }
        }
    }
}
