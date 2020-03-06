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

        public Amenity GetAmenity(string amenity)
        {
            Amenity a = new Amenity();

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT AmenityID, Amenity FROM Amenities" + 
                        $" WHERE Amenity = '{amenity}';";
                Console.WriteLine($"!!!: {query}");
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // get amenity
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        a.AmenityID = (int)reader[0];
                       // a.ParkID = (string)reader[1];
                        a.Amen = (string)reader[1];
                    }
                }

                // close connection
                sqlConnection.Close();
            }

            return a;
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

        public void DeleteAmenitiesFor(string parkID)
        {
            string deleteAmenities = "DELETE FROM Amenities " +
                $" WHERE ParkID = '{parkID}';";
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                SqlCommand sqlCommand = new SqlCommand(deleteAmenities, sqlConnection);

                // open connection
                sqlConnection.Open();

                // delete amenities from that park
                sqlCommand.ExecuteNonQuery();

                // close connection
                sqlConnection.Close();
            }
        }

        public void TurnOnAmenity(string parkID, Amenity amenity)
        {
            //QueryAmenityImages queryAmenityImages = new QueryAmenityImages();
            int imageID = 1;
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "INSERT INTO Amenities(ParkID, Amenity, Quantity, ImageID)" +
                        $" VALUES('{parkID}', '{amenity.Amen}', 1, {imageID});";
                Console.WriteLine($"ADD AMENITY: {query}");
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // add that amenity
                sqlCommand.ExecuteNonQuery();

                // close connection
                sqlConnection.Close();
            }
        }

        public void updateAmenities(AzureMasterPark azureMasterPark)
        {
            string parkID = azureMasterPark.AzurePark.ParkID;
            // delete all the parks amenities
            DeleteAmenitiesFor(parkID);
            Console.WriteLine($"DELETED AMENITIES FOR {parkID}");
            List<Amenity> heldByPark = azureMasterPark.Amenitys;
           
            foreach(Amenity amenity in heldByPark)
            {
                // turn on every amenity
                Console.WriteLine($"ATTEMPTING TO TURN ON AMENITY: {amenity}");
                TurnOnAmenity(parkID, amenity);
            }
        }
    }
}
