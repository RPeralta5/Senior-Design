using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Parks_SpecialEvents.Models
{
    public class QueryParkImages
    {
        const string PARK_DB_CONNECTION = @"data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";

        public QueryParkImages()
        {
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

            int counter = 0;
            foreach(string image in images)
            {
                string parkFoler = generateParkFolderFor(parkID);
                Console.WriteLine($"parkFolder: {parkFoler}");
                counter++;
                if(images.Count == 1)
                {
                    query += "VALUES " +
                            $"('{parkID}', '/images/{parkFoler}/{image}');";
                } else
                {
                    if(counter == 1)
                    {
                        query += "VALUES " +
                            $"('{parkID}', '/images/{parkFoler}/{image}'),";
                    } else
                    {
                        if(counter == images.Count)
                        {
                            query += $" ('{parkID}', '/images/{parkFoler}/{image}');";
                        } else
                        {
                            query += $" ('{parkID}', '/images/{parkFoler}/{image}'),";
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
