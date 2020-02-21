﻿using System;
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

        public void addImages(AzureParkImages park)
        {
            string query = "INSERT INTO ParkImages(ParkID, ImagePath)";
            Console.WriteLine($"NUM IMAGES: {park.Images.Count}");
            int counter = 0;

            // generate folder path
            string parkFolder = generateParkFolderFor(park.ParkID);
            Console.WriteLine($"parkFolder: {parkFolder}");
            
            // create directory for park images
            string pathString = Path.Combine(hostingEnvironment.WebRootPath + "/images/", $"{parkFolder}");
            Directory.CreateDirectory(pathString);
            Console.WriteLine($"created directory : {pathString}");

            foreach (IFormFile image in park.Images)
            {
                
                Console.WriteLine("image: " + image);
               
                // GET DESTINATION PATH OF WHERE THE IMAGE IS GOING TO BE PLACED
                var destinationFile = Path.Combine(hostingEnvironment.WebRootPath + $"/images/{parkFolder}", Path.GetFileName(image.FileName));
                Console.WriteLine($"DESTINATION FILE PATH: {destinationFile}");
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
