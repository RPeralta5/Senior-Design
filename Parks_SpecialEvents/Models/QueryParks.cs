using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Parks_SpecialEvents.Models
{
    public class QueryParks
    {
        List<AzurePark> azure;
        const string PARK_DB_CONNECTION = @"data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";
        private readonly IHostingEnvironment hostingEnvironment;

        public QueryParks()
        {
            azure = new List<AzurePark>();
        }

        public QueryParks(IHostingEnvironment e)
        {
            hostingEnvironment = e;
            azure = new List<AzurePark>();
        }

        public AzurePark getParkInfo(string parkID)
        {
            AzurePark azurePark = new AzurePark();
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT * FROM Parks" +
                    $" WHERE ParkID = '{parkID}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // get ALL information about the park
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        azurePark.ParkID = (string)reader[0];
                        azurePark.ParkName = (string)reader[1];
                        azurePark.ParkLastName = (string)reader[2];
                        azurePark.Address = (string)reader[3];
                        azurePark.StreetNumber = (string)reader[4];
                        azurePark.StreetName = (string)reader[5];
                        azurePark.City = (string)reader[6];
                        azurePark.Zip = (string)reader[7];
                        azurePark.FacilityPhone = (string)reader[8];
                        azurePark.Lat = (double)reader[9];
                        azurePark.Lng = (double)reader[10];
                        azurePark.GISAcres = (double)reader[11];
                        azurePark.InventoryAcres = (double)reader[12];
                        azurePark.ImagePath = Path.Combine(hostingEnvironment.WebRootPath, (string)reader[13]);
                    }
                }

                // close connection
                sqlConnection.Close();
            }
            return azurePark;
        }

        public string getParkFolder(string parkID)
        {
            QueryParkImages queryParkImages = new QueryParkImages();
            return queryParkImages.generateParkFolderFor(parkID);
        }

        public string getParkThumbNailPath(string parkID)
        {
            string thumbNailPath = "";
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT Image FROM Parks" +
                    $" WHERE ParkID = '{parkID}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // get park thumbnail path
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        thumbNailPath = (string)reader[0];
                    }
                }

                // close sql connection
                sqlConnection.Close();
            }
            return thumbNailPath;
        }

        private void newThumbnail(AzureMasterPark azureMasterPark)
        {
            string parkID = azureMasterPark.AzurePark.ParkID;
            string newThumb = azureMasterPark.AzurePark.Image.FileName;
            string destination = Path.Combine(hostingEnvironment.WebRootPath, "images/ParkThumbnails/" + newThumb);

            // get thumbnail
            string oldThumbnail = getParkThumbNailPath(parkID);
            Console.WriteLine($"OLD THUMBNAIL: {oldThumbnail}");

            // delete image from project
            string filepath = Path.Combine(hostingEnvironment.WebRootPath, oldThumbnail.Substring(1, oldThumbnail.Length - 1));
            Console.WriteLine($"Delete thumbnail: {filepath}");
            File.Delete(filepath);

            // insert new thumbnail
            azureMasterPark.AzurePark.Image.CopyTo(new FileStream(destination, FileMode.Create));
            Console.WriteLine($"new thumbnail: {destination}");
        }

        private void renameParkDirectory(AzureMasterPark azureMasterPark)
        {
            Console.WriteLine($"hosting environemnt from Query Parks: {hostingEnvironment.WebRootPath}");
            // get park directory
            string parkID = azureMasterPark.AzurePark.ParkID;
            string opd = getParkFolder(parkID); // opd
            string oldParkDirectory = Path.Combine(hostingEnvironment.WebRootPath, "images/" + opd);
            string ampd = azureMasterPark.AzurePark.ParkLastName.Replace(" ", "");
            Console.WriteLine($"OLD PARK DIRECTORY: {oldParkDirectory}");
            Console.WriteLine($"NEW PARK DIRECTORY: {ampd}");

            if (opd != ampd) // ampd = azure master park directory (new park directory)
            {
                Console.WriteLine("PARK LAST NAME WAS CHANGED. UPDATING PARK DIRECTORY");
                // create that new directory
                QueryParkImages queryParkImages = new QueryParkImages(hostingEnvironment);
                string newDirectory = "images/" + queryParkImages.generateNewParkFolderFor(ampd);
                Console.WriteLine($"NEW park directory: {newDirectory}");
                string webDirectory = Path.Combine(hostingEnvironment.WebRootPath, newDirectory);
                Console.WriteLine($"WEB directory: {webDirectory}");
                Directory.CreateDirectory(webDirectory);

                // move files over from old directory to new directory
                if (Directory.Exists(oldParkDirectory))
                {
                    string[] files = Directory.GetFiles(oldParkDirectory);

                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        string fileName = Path.GetFileName(s);
                        string destFile = Path.Combine(hostingEnvironment.WebRootPath, "images/" + $"{ampd}/"+ fileName);
                        File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
                Console.WriteLine($"THIS SHOULD HAVE MOVED OLD IMAGES TO THE NEW DIRECTORY");

                // delete old directory
                Directory.Delete(oldParkDirectory, true);
                Console.WriteLine($"DELETED OLD PARK DIRECTORY: {oldParkDirectory}");
            }

        }

        private void changeDirectoryNameInAzureDB(AzureMasterPark azureMasterPark)
        {
            string parkID = azureMasterPark.AzurePark.ParkID;
            QueryParkImages queryParkImages = new QueryParkImages();
            List<Image> images = queryParkImages.getImages(parkID);

            string[] sp = images[0].ImagePath.Split("/");
            string oldDirectory = sp[2]; // gets name of directory
            Console.WriteLine($"CHANGE DIRECTORY NAME IN AZURE (OLD DIR): {oldDirectory}");
            string newDirectory = azureMasterPark.AzurePark.ParkLastName.Replace(" ", "");

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                sqlConnection.Open();
                foreach(Image image in images)
                {
                    string newPath = image.ImagePath.Replace(oldDirectory, newDirectory);
                    string query = "UPDATE ParkImages" +
                    $" SET ImagePath = '{newPath}'" +
                    $" WHERE ImageID = '{image.ImageID}';";
                    Console.WriteLine($"IMAGES QUERY UPDATE: {query}");
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    // update images
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public void UpdatePark(AzureMasterPark azureMasterPark)
        {
            AzurePark park = azureMasterPark.AzurePark;
            renameParkDirectory(azureMasterPark);

            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "";
                string updateParkInfo = "";
                if (park.Image == null)
                { // don't update thumbnail
                    updateParkInfo = "UPDATE Parks " +
                                $" SET ParkName = '{park.ParkName}', ParkLastName = '{park.ParkLastName}', Address = '{park.Address}', Street_Number = '{park.StreetNumber}', " +
                                $" Street_Name = '{park.StreetName}', City = '{park.City}', Zip = '{park.Zip}', FacilityPhone = '{park.FacilityPhone}', Lat = {park.Lat}, Lng = {park.Lng}, " +
                                $" GIS_Acres = {park.GISAcres}, Inventory_Acres = {park.InventoryAcres}" +
                                $" WHERE ParkID = '{park.ParkID}';";
                } else
                {
                    // get image
                    IFormFile image = azureMasterPark.AzurePark.Image;
                    string imagePath = "/images/ParkThumbnails/" + image.FileName;
                    Console.WriteLine($"image path: {imagePath}");
                    // overrider old thumbnail with new thumbnail
                    newThumbnail(azureMasterPark);

                    updateParkInfo = "UPDATE Parks " + 
                        $" SET ParkName = '{park.ParkName}', ParkLastName = '{park.ParkLastName}', Address = '{park.Address}', Street_Number = '{park.StreetNumber}', " + 
                        $" Street_Name = '{park.StreetName}', City = '{park.City}', Zip = '{park.Zip}', FacilityPhone = '{park.FacilityPhone}', Lat = {park.Lat}, Lng = {park.Lng}, " + 
                        $" GIS_Acres = {park.GISAcres}, Inventory_Acres = {park.InventoryAcres}, Image = '{imagePath}' " +
                        $" WHERE ParkID = '{park.ParkID}';";
                }

                changeDirectoryNameInAzureDB(azureMasterPark);
                Console.WriteLine("DONE UPDATING AZURE");

                // query to update park info
                query += updateParkInfo;
                Console.WriteLine($"UPDATE PARK INFO QUERY: {query}");

                // query to update park amenities
                QueryAmenities queryAmenities = new QueryAmenities();
                queryAmenities.updateAmenities(azureMasterPark);

                // update events
                QueryEvents queryEvents = new QueryEvents();
                queryEvents.updateEvents(azureMasterPark); 


                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // update park
                sqlCommand.ExecuteNonQuery();

                // close sql connection
                sqlConnection.Close();
            }
        }

        public void DeletePark(string parkID)
        {   // need to delete everything assiciated with the park
            Console.WriteLine($"DELETING: {parkID}");
            // deleting park folders

            try
            {
                // deleting park folder (holding all images of park)
                string parkFolder = getParkFolder(parkID);
                //Console.WriteLine($"path: {hostingEnvironment.WebRootPath + $"/images/{parkFolder}"}");
                System.IO.Directory.Delete(hostingEnvironment.WebRootPath + $"/images/{parkFolder}", true);

                // deleting park thumbnail
                string thumbnail = getParkThumbNailPath(parkID);
                System.IO.FileInfo image = new System.IO.FileInfo(hostingEnvironment.WebRootPath + thumbnail);

                try
                {
                    image.Delete();
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine("SOMEHTING WENT WRONG IN DELETING PARK THUMBNAIL");
                    Console.WriteLine(e.Message);
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("SOMETHING WENT WRONG IN DELETING PARK FOLDER");
                Console.WriteLine(e.Message);
            }

            // deleting park from database
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "DELETE FROM ParkImages " + 
                $" WHERE ParkID = '{parkID}';" +

                " DELETE FROM Event " +
                $" WHERE ParkID = '{parkID}'; " +

                " DELETE FROM Amenities " +
                $" WHERE ParkID = '{parkID}'; " +

                " DELETE FROM Parks " +
                $" WHERE ParkID = '{parkID}'; ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // delete park
                sqlCommand.ExecuteNonQuery();
                /* used for
                 *  INSERT, DELETE, UPDATE, and SET statements.
                */

                // close sql connection
                sqlConnection.Close();
            }

        }

        public string getParkName(string parkID)
        {
            string parkName = "";
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT ParkName FROM Parks" +
                    $" WHERE ParkID = '{parkID}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // get parkName
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        parkName = (string) reader[0];
                    }
                }

                // close sql connection
                sqlConnection.Close();
            }
            return parkName;
        }

        public List<AzurePark> getParkIDAndParKName()
        {
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT ParkID, ParkName FROM Parks;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // get parkID and ParkName
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        AzurePark e = new AzurePark();
                        e.ParkID = (string) reader[0];
                        e.ParkName = (string) reader[1];
                        azure.Add(e);
                    }
                }
                // close sql connection
                sqlConnection.Close();
            }
            return azure;
        }
    }
}
