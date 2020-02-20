using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Parks_SpecialEvents.Models
{
    public class QueryParkImages
    {
        const string PARK_DB_CONNECTION = @"data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";
        private readonly IHostingEnvironment hostingEnvironment;

        public QueryParkImages()
        {
        }

        public QueryParkImages(IHostingEnvironment e)
        {
            hostingEnvironment = e;
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

        public void addImages(List<string> images, string parkID)
        {
            string query = "INSERT INTO ParkImages(ParkID, ImagePath)";
            Console.WriteLine($"NUM IMAGES: {images.Count}");
            int counter = 0;
            foreach(string image in images)
            {
                
                Console.WriteLine("image: " + image);
                string parkFolder = generateParkFolderFor(parkID);
                Console.WriteLine($"parkFolder: {parkFolder}");

                // GET DESTINATION PATH OF WHERE THE IMAGE IS GOING TO BE PLACED
               // var destinationFile = Path.Combine(hostingEnvironment.WebRootPath + $"/images/{parkFolder}", Path.GetFileName(image));
               // Console.WriteLine($"DESTINATION FILE PATH: {destinationFile}");
                // PASTE IMAGE THERE
                //image.CopyTo(new FileStream(destinationFile, FileMode.Create));

                counter++;
                if(images.Count == 1)
                {
                    query += "VALUES " +
                            $"('{parkID}', '/images/{parkFolder}/{image}');";
                } else
                {
                    if(counter == 1)
                    {
                        query += "VALUES " +
                            $"('{parkID}', '/images/{parkFolder}/{image}'),";
                    } else
                    {
                        if(counter == images.Count)
                        {
                            query += $" ('{parkID}', '/images/{parkFolder}/{image}');";
                        } else
                        {
                            query += $" ('{parkID}', '/images/{parkFolder}/{image}'),";
                        }
                    }
                }

            }
            Console.WriteLine($"query: {query}");
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // add images to park
                sqlCommand.ExecuteReader();

                // close connection
                sqlConnection.Close();
            }
        }
    }
}
