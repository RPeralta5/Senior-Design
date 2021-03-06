﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Parks_SpecialEvents.Models
{
    public class QueryAmenities
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IConfiguration _config;

        public QueryAmenities()
        {
        }

        public QueryAmenities(IConfiguration config)
        {
            _config = config;
        }

        public QueryAmenities(IHostingEnvironment e, IConfiguration config)
        {
            hostingEnvironment = e;
            _config = config;
        }

        private string PARK_DB_CONNECTION
        {
            get { return _config.GetValue<string>("ConnectionString:default"); }
        }

        public Amenity GetAmenity(string amenity)
        {
            Amenity a = new Amenity();

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT AmenityID, Amenity FROM Amenities" + 
                        $" WHERE Amenity = '{amenity}';";
      
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

        public List<Amenity> GetAmenityImagesForParkID(string parkID)
        {
            List<Amenity> amenities = new List<Amenity>();
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = $"SELECT Amenity, Image FROM Amenities, AmenityImages WHERE ParkID = '{parkID}' AND Amenities.ImageID = AmenityImages.ImageID";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // get amenities form this park
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Amenity a = new Amenity();
                        a.Amen = (String)reader[0];
                        a.Image = (string)reader[1];
                        amenities.Add(a);
                    }
                }

                // close sql connection
                sqlConnection.Close();
            }
            return amenities;

        }

        public List<Amenity> getAmenitiesFrom(string parkID)
        {
            List<Amenity> amenities = new List<Amenity>();
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT Amenity FROM Amenities" + 
                    $" WHERE ParkID = '{parkID}'; ";
                
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
           
            return amenities;
        }

        public List<Amenity> filterAmenitys(List<Amenity> fromPark, List<Amenity> allAmenities)
        {
            List<Amenity> amenities = new List<Amenity>();

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
                        a.Flag = false;
                        amenities.Add(a);
                        break;
                    }
                    if (count == fromPark.Count - 1)
                    {
                        a.Flag = true;
                        amenities.Add(a);
                    }
                    count++;
                }
            }
            
            return amenities;
        }

        public int GetImageID(string amenity)
        {
            int imageID = 1;
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT DISTINCT ImageID" +
                        " FROM Amenities" +
                        $" WHERE Amenity = '{amenity}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // get id
                imageID = (int)sqlCommand.ExecuteScalar();

                // close sql connection
                sqlConnection.Close();
            }
            return imageID;
        }

        public void addAmenities(string parkID, List<string> amenities)
        {

            // if no amenities were added, don't run query
            if(amenities.Count != 0)
            {
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

                        // get image id
                        QueryAmenityImages queryAmenityImages = new QueryAmenityImages();
                        int imageID = GetImageID(amenity);

                        // query
                        if (amenities.Count == count)
                        {
                            query += $"('{parkID}', '{amenity}', 1, {imageID});";
                        } else
                        {
                            query += $"('{parkID}', '{amenity}', 1, {imageID}), ";
                        }
                      
                    }
                
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    // add to data base
                    sqlCommand.ExecuteNonQuery(); // used to be executeReader()

                    // close connection
                    sqlConnection.Close();
                }
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
            int imageID = GetImageID(amenity.Amen);
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "INSERT INTO Amenities(ParkID, Amenity, Quantity, ImageID)" +
                        $" VALUES('{parkID}', '{amenity.Amen}', 1, {imageID});";

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
     
            List<Amenity> heldByPark = azureMasterPark.Amenitys;
           
            foreach(Amenity amenity in heldByPark)
            {
                // turn on every amenity
                TurnOnAmenity(parkID, amenity);
            }
        }
    }
}
