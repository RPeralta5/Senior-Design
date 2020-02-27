using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;

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
            Console.WriteLine($"HOSTING: {hostingEnvironment}");
            azure = new List<AzurePark>();
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
