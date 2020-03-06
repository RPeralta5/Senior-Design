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

        public List<Amenity> getAmenitiesFrom(string parkID)
        {
            Console.WriteLine($"getting amenities from {parkID}");
            List<Amenity> amenities = new List<Amenity>();
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT Amenity FROM Amenities" + 
                    $" WHERE ParkID = '{parkID}'; ";
                Console.WriteLine($"query: {query}");
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // get amenities form this park
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Amenity a = new Amenity();
                        a.Amen = (String)reader[0];
                        amenities.Add(a);
                    }
                }

                // close sql connection
                sqlConnection.Close();
            }
            Console.WriteLine($"QUERY CAPTURED: {amenities.Count}");
            return amenities;
        }

        public List<Amenity> filterAmenitys(List<Amenity> fromPark, List<Amenity> allAmenities)
        {
            List<Amenity> amenities = new List<Amenity>();
            Console.WriteLine($"PARK HAS: {fromPark.Count}");
            Console.WriteLine($"ALL AMENITITYS: {allAmenities.Count}");

            if(fromPark.Count == 0)
            {
                foreach(Amenity a in allAmenities)
                {
                    a.Flag = true;
                    amenities.Add(a);
                }
                return amenities;
            }
            

            foreach (Amenity a in allAmenities)
            {
                int count = 0;

                foreach (Amenity e in fromPark)
                {
                    if (e.Amen == a.Amen)
                    {
                        Console.WriteLine($"park has {e.Amen}");
                        a.Flag = false;
                        amenities.Add(a);
                        break;
                    }
                    if (count == fromPark.Count - 1)
                    {
                        Console.WriteLine($"FLAGGED: {a.Amen}");
                        a.Flag = true;
                        amenities.Add(a);
                    }
                    count++;
                }
            }
            
            return amenities;
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
                sqlCommand.ExecuteNonQuery(); // used to be executeReader()

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

        public List<Amenity> GetAmenities()
        {
            List<Amenity> amenities = new List<Amenity>();
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT DISTINCT Amenity FROM Amenities;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // read data
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Amenity a = new Amenity();
                        a.Amen = (string) reader[0];
                        amenities.Add(a);
                    }
                }

                // close connection
                sqlConnection.Close();
            }
            return amenities;
        }

        public string updateAmenities(AzureMasterPark azureMasterPark)
        {
            string parkID = azureMasterPark.AzurePark.ParkID;
            string query = "UPDATE Amenities";

            List<Amenity> allAmenities = GetAmenities();
            List<Amenity> heldByPark = getAmenitiesFrom(parkID);

            List<Amenity> filtered = filterAmenitys(heldByPark, allAmenities);

            foreach(Amenity amenity in filtered)
            {
                if(amenity.Flag == true)
                {
                   // query += ""
                }
            }

            return query;
        }
    }
}
