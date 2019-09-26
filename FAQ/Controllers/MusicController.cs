using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFGetStarted.AspNetCore.NewDb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
    public class MusicController : Controller
    {
        // CONNECTION STRING
        static String cString = "data source=.; database = Music; user id = sa; password = myPassw0rd;";

        // STORE DATA
        Storage storage = new Storage();

        // GET: /<controller>/
        public IActionResult Index()
        {
            using (SqlConnection sqlConnection = new SqlConnection(cString))
            {
                // COMMAND TO EXECUTE
                String command = "SELECT * FROM Artists;";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPENING THE CONNECTION
                sqlConnection.Open();

                // READ THE DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        storage.AddItem(new Item((int) reader[0], (string) reader[1], (DateTime) reader[2]));
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }

                // CLOSE THE CONNECTION
                sqlConnection.Close();
            }
            // STORE IN VIEWBAG
            ViewBag.storing = storage;
            return View();
        }

        // DISPLAYS A SINGLE ARTIST TO THE PAGE
        public IActionResult Artist(int id)
        {

            using (SqlConnection sqlConnection = new SqlConnection(cString))
            {
                // SQL QUERY

                string command = $"SELECT * FROM Artists WHERE ArtistId = {id}";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ THE DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    Console.WriteLine("Faith: ");
                    while(reader.Read())
                    {
                        storage.AddItem
                            (new Item((int) reader[0], (string) reader[1],
                            (DateTime) reader[2]));
                    }
                }
                // CLOSE THE CONNECTION
                sqlConnection.Close();
            }

            ViewBag.storing = storage;
            return View();
        }

        public IActionResult Search(string search)
        {

            Console.WriteLine($"SEARCH: {search}");
            using(SqlConnection sqlConnection = new SqlConnection(cString))
            {
                // SQL QUERY

                string command = $"SELECT * FROM Artists WHERE ArtistName LIKE '%{search}%';";
                Console.WriteLine("QUERY: " + command);
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        storage.AddItem
                            (new Item((int) reader[0], (string) reader[1],
                            (DateTime) reader[2]));
                    }
                }

                // CLOSE CONNECTION
                sqlConnection.Close();
            }

            ViewBag.storing = storage;
            return View();
        }
    }
}
