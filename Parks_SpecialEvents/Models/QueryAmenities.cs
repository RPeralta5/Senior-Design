using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;

namespace Parks_SpecialEvents.Models
{
    public class QueryAmenities
    {
        const string PARK_DB_CONNECTION = @"data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";
        private readonly IHostingEnvironment hostingEnvironment;

        public QueryAmenities()
        {
        }

        public QueryAmenities(IHostingEnvironment e)
        {
            hostingEnvironment = e;
        }

        public void addAmenities(string parkID, List<string> amenities)
        {
            Console.WriteLine($"AMENITY SIZE: {amenities.Count}");
            // INSERT INTO Amenities(ParkID, Amenity, Quantity, ImageID)
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // open connection
                sqlConnection.Open();

                string query = "INSERT INTO Amenities(ParkID, Amenity, Quantity, ImageID) " +
                        $"VALUES ";
                // insert data
                int count = 0;
                foreach (string amenity in amenities)
                {
                    count++;
                    // query
                    if (amenities.Count == count)
                    {
                        query += $"('{parkID}', '{amenity}', 1, 1);";
                    } else
                    {
                        query += $"('{parkID}', '{amenity}', 1, 1), ";
                    }
                      
                }
                Console.WriteLine($"QUERY: {query}");
                
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // add to data base
                sqlCommand.ExecuteReader();

                // close connection
                sqlConnection.Close();
            }
            
        }

        public List<string> getAmenities()
        {
            List<string> amenities = new List<string>();
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT DISTINCT Amenity FROM Amenities;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // read data
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        amenities.Add((string)reader[0]);
                    }
                }

                // close connection
                sqlConnection.Close();
            }
            return amenities;
        }
    }
}
