﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Parks_SpecialEvents.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parks_SpecialEvents.Controllers
{
    public class AdminController : Controller
    {

        private readonly IHostingEnvironment hostingEnvironment;

        // THESE ARE USED FOR REUSE : NO NEED TO QUERY TWICE
        private static string staticParkID;
        private static List<Event> originalEvents;

        public AdminController(IHostingEnvironment e)
        {
            hostingEnvironment = e;
        }

        // PARKS DATABASE CONNECTION STRING
        const string PARK_DB_CONNECTION = "data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";

        // QUERY FOR ALL PARKS
        const string ALL_PARKS = "SELECT ParkID, ParkName, Address, Lat, Lng FROM Parks;";

        // QUERY FOR ALL EVENTS
        const string ALL_EVENTS = "SELECT DISTINCT Event, Href FROM Events";

        // QUERY FOR ALL AMENITIES
        const string ALL_AMENITIES = "SELECT DISTINCT Amenity, Image FROM Amenities, AmenityImages WHERE Amenities.ImageID = AmenityImages.ImageID;";

        private string GetParkNameByID(string parkID)
        {
            string parkName = "";
            using(SqlConnection sqlConnnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string query = "SELECT ParkName FROM Parks" +
                   $" WHERE ParkID = '{parkID}'; ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                sqlConnnection.Open();

                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        parkName = (string)reader[0];
                    }
                }
            }
            return parkName;
        }

        private ParkDB QueryParks(string query)
        {
            ParkDB parkDB = new ParkDB();
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        //ParkID, ParkName, Address, Lat, Lng
                        // ID, NAME ,ADDRESS, LAT, LNG, PERMITABLE, IMAGE
                        parkDB.AddPark(new Park( (string) reader[0], (string) reader[1], (string) reader[2],
                            (double) reader[3], (double) reader[4], "", ""));
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            return parkDB;
        }

        private List<Event> QueryEvents(string query)
        {
            List<Event> events = new List<Event>();
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        //Console.WriteLine($"DISTINCT EVENT: {reader[0]}");
                        //Console.WriteLine($"DISTINCT HREF: {reader[1]}");
                        events.Add(new Event((string)reader[0], (string)reader[1],
                            false));
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            return events;
        }

        private AmenityDB QueryAmenities(string query)
        {
            AmenityDB amenityDB = new AmenityDB();
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXCECUTE
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        //Console.WriteLine($"AMENITY: {reader[0]} IMAGEID: {reader[1]}");
                        // AMENITYID, PARKID, AMENITY, QUANITY, IMAGEID
                        amenityDB.addAmenity(new Amenity( 0, "", (string) reader[0],
                            0, (string) reader[1]));
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            return amenityDB;
        }

        private int InsertIntoAmenityImages(IFormFile image)
        {
            int imageID = -1;
            string databaseFilePath = $"/images/AmenityImages/{image.FileName}";
            Console.WriteLine($"DATABASE FILE PATH: {databaseFilePath}");

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string injection = $"INSERT INTO AmenityImages(Image) VALUES('{databaseFilePath}');";
                SqlCommand command = new SqlCommand(injection, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // EXECUTE INJECTION
                command.ExecuteReader();
                sqlConnection.Close();
                // NOW GET THE AMENITY ID THAT WAS JUST CREATED
                string query = $"SELECT ImageID FROM AmenityImages WHERE Image = '{databaseFilePath}';";
                command = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                // READ DATA
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        imageID = (int) reader[0];
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();

            }
            Console.WriteLine($"IMAGE ID: {imageID}");
            return imageID;
        }

        private void InsertAmenity(string parkID, string amenity, int quanity, int imageID)
        {   // CONNECT TO THE DATABASE
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string query = "INSERT INTO Amenities(ParkID, Amenity, Quantity, ImageID)" +
                        $" VALUES ('{parkID}', '{amenity}', {quanity}, '{imageID}');";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                Console.WriteLine($"QUERY: {query}");
                // OPEN CONNECTION
                sqlConnection.Open();

                if(has(parkID, amenity))
                {
                    Console.WriteLine($"AMENITY: {amenity} is already in the database");
                    Console.WriteLine($"DID NOT ADD {amenity}");
                    /*
                     * DONT INSERT
                     *  AMENITY ALREADY IN
                     *  DATA BASE
                     */
                    // CLOSE CONNECTION
                    sqlConnection.Close();

                } else
                {
                    Console.WriteLine("AMENITY IS NOT IN DATABASE");
                    Console.WriteLine("AMENITY IS BEING ADDED I THINK...");
                    // INSERT AMENITY INTO DATABASE
                    sqlCommand.ExecuteReader();
            
                    // CLOSE CONNECTION
                    sqlConnection.Close();
                }
            }
        }

        private Boolean has(string parkID, string amenity)
        {
            string dataBaseResult = "";
            // CONNECT TO PARKS DATA BASE
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string query = $"SELECT Amenity FROM Amenities WHERE ParkID = '{parkID}' AND Amenity = '{amenity}'; ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        dataBaseResult = (string) reader[0];
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }

            if(dataBaseResult == amenity)
            {
                return true;
            }
            return false;
        }

        private int getImageID(string amenity)
        {
            int imageID = -1;
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // QUERY
                string query = "SELECT DISTINCT AmenityImages.ImageID FROM AmenityImages, Amenities "
                    + $"WHERE Amenities.Amenity = '{amenity}' AND Amenities.ImageID = AmenityImages.ImageID;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        imageID = (int)reader[0];
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            return imageID;
        }

        private string getParkID(string parkName)
        {
            string parkID = "EMPTY";
            // CONNNECT TO PARKS DATABASE
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string query = $"SELECT ParkID FROM Parks WHERE ParkName = '{parkName}';";
                Console.WriteLine($"QUERY TO GET PARK ID: {query}");
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        parkID = (string)reader[0];
                        Console.WriteLine($"PARK ID: {parkID}");
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            return parkID;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string parkID, string amenity, int quanity, string newAmenity, int newQuanity, IFormFile image = null)
        {
            Console.WriteLine("ADD AMENITY METHOD");
            if (image == null)
            {
                Console.WriteLine($"NO IMAGE: GOING TO FETCH FOR THE IMAGE: Amenity: {amenity}");
                int imgID = getImageID(amenity);
                Console.WriteLine($"IMAGE: {imgID}");
                // ADD AMENITY ONT DATABASE
                InsertAmenity(parkID, amenity, quanity, imgID);
            } else
            {
                Console.WriteLine($"RESULTS:  PARKID: {parkID}, AMENITY: {newAmenity}, QUANITY: {newQuanity}, IMAGE: {image.FileName}");

                // GET DESTINATION PATH OF WHERE THE IMAGE IS GOING TO BE PLACED
                var destinationFile = Path.Combine(hostingEnvironment.WebRootPath + "/images/AmenityImages", Path.GetFileName(image.FileName));

                // PASTE IMAGE THERE
                image.CopyTo(new FileStream(destinationFile, FileMode.Create));

                Console.WriteLine($"IMAGE FILE PATH: {destinationFile}");

                // INSERT AMENITY INTO DATABASE
                int imgID = InsertIntoAmenityImages(image);

                // ADD AMENITY ONT DATABASE
                InsertAmenity(parkID, newAmenity, newQuanity, imgID);

                // ignore just testing
            }

            return RedirectToAction("AddAmenity");
        }

        // GET: ADD AMENITY TO A PARK
        public IActionResult AddAmenity()
        {
            ViewBag.Parks = QueryParks(ALL_PARKS);
            ViewBag.Amenities = QueryAmenities(ALL_AMENITIES);
            return View();
        }

        public IActionResult Delete(string parkName, string amenity)
        {
            Console.WriteLine("DELETE METHOD");
            // CONNECTION TO PARKS DATA BASE
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                string parkID = getParkID(parkName);
                // COMMAND TO EXECUTE
                string query = $"DELETE FROM Amenities WHERE ParkID = '{parkID}' AND Amenity = '{amenity}'; ";
                Console.WriteLine($"QUERY DELETE : {query}");
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // DELETE AMENITY FROM THAT SPECIFIC PARK
                sqlCommand.ExecuteReader();

                // CLOSE CONNECTION
                sqlConnection.Close();
                Console.WriteLine($"DELETED {amenity} from Park: {parkName}");
            }

            // DELETE THE IMAGE FROM /images/AmenityImages/imageName


            return RedirectToAction("DeleteAmenity");
        }

        public IActionResult DeleteAmenity()
        {
            ViewBag.Parks = QueryParks(ALL_PARKS);
            ViewBag.Amenities = QueryAmenities(ALL_AMENITIES);
            return View();
        }

        private void UpdateDBAmenity(string parkName, string amenity, string setAmenity, int setQuanity)
        {
            Console.WriteLine($"UPDATE DB AMENITY METHOD");
            string parkID = getParkID(parkName);
            Console.WriteLine($"PARK ID: {parkID}");
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string query = $"UPDATE Amenities" +
                    $" SET Amenity = '{setAmenity}', Quantity = {setQuanity}" +
	                $" WHERE ParkID = '{parkID}' AND Amenity = '{amenity}'; ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                Console.WriteLine($"UPDATE QUERY: {query}");

                // OPEN CONNECTION
                sqlConnection.Open();

                // EXECUTE UPDATE
                sqlCommand.ExecuteReader();

                // CLOSE CONNECTION
                sqlConnection.Close();
            }

        }

        public IActionResult Update(string park = "", string singleAmenity = "EMPTY", string setSingleName = "", int setSingleQuanity= -1,
            string allAmenityNamed = "")
        {
            Console.WriteLine("UPDATE UPDATE");
            Console.WriteLine($"PARK: {park}");
            Console.WriteLine($"SINGLE OG AMENITY: {singleAmenity}");
            Console.WriteLine($"SET SINGLE NAME: {setSingleName}");
            Console.WriteLine($"SET SINGLE QUANITY: {setSingleQuanity}");
            Console.WriteLine($"ALL AMENITY NAMED: {allAmenityNamed}");

            if(allAmenityNamed != "EMPTY")
            {
                //UpdateAllAmenitiesNamed(allAmenityNamed);
            } else
            {
                UpdateDBAmenity(park, singleAmenity, setSingleName, setSingleQuanity);
            }
            return RedirectToAction("UpdateAmenity");
        }

        public IActionResult UpdateAmenity()
        {
            Console.WriteLine("GOING TO UPDATE AMENITY PAGE");

            ViewBag.Parks = QueryParks(ALL_PARKS);
            ViewBag.Amenities = QueryAmenities(ALL_AMENITIES);
            return View();
        }

        private List<Event> filter(List<Event> allEvents, List<Event> heldByPark)
        {
            List<Event> events = new List<Event>();

            foreach(Event all in allEvents)
            {
                int count = 0;
                Console.WriteLine($"CHECKING: {all.P}");
                foreach (Event held in heldByPark)
                {
                    if(held.P == all.P)
                    {
                        Console.WriteLine($"{all.P} is HELD BY PARK");
                        events.Add(new Event(all.P, all.Href, true));
                        break;
                    }
                    if(count == heldByPark.Count - 1)
                    {
                        Console.WriteLine($"{all.P} is NOT HELD BY PARK");
                        events.Add(new Event(all.P, all.Href, false));
                    }
                    count++;
                }
            }
            Console.WriteLine(events.Count);
            return events;
        }

        private void UpdateParkEvent(string e)
        {
            Console.WriteLine($"TURNING ON EVENT: {e}");
        }

        private void TurnOffAllEventsForPark(string parkID)
        {
            Console.WriteLine($"TURNED OFF ALL EVENTS FOR {parkID}");
        }

        [HttpPost]
        public IActionResult EditPark(ParkEventModel parkEventModel) // THIS USED TO BE EDIT PARK
        {
            Console.WriteLine("PARK EVENT MODEL");
            Console.WriteLine($"ParkName: {parkEventModel.ParkName}");
            Console.WriteLine($"ListSize: {parkEventModel.Events.Count}");
            var updatedEvents = Request.Form["EVENTS"];
    
            Console.WriteLine($"UPDATED EVENTS: {updatedEvents}");

            // SET ALL PARK EVENTS TO FLAG : TURRN OFF EVENTS
            TurnOffAllEventsForPark(staticParkID);

            // TURN ON ALL NEW : UPDATED EVENTS
            foreach (String e in updatedEvents)
            {
                Console.WriteLine($"EVENTS FROM EDIT PARK: {e}");
                UpdateParkEvent(e);
            }
            return RedirectToAction("UpdateParkIndexRazor");
        }

        [HttpGet]
        public IActionResult UpdateParkRazor(string parkID)
        {
            Console.WriteLine($"PARK ID: {parkID}");
            staticParkID = parkID;

            // PARK NAME
            string parkName = GetParkNameByID(parkID);
            ViewBag.ParkName = parkName;

            // GET ALL EVENTS
            List<Event> allEvents = QueryEvents(ALL_EVENTS);

            // EVENTS HELD BY PARK
            List<Event> heldByPark = QueryEvents(ALL_EVENTS + $" WHERE ParkID= '{parkID}';");
            originalEvents = heldByPark;

            List<Event> list = filter(allEvents, heldByPark);
            ViewBag.Events = list;

            ParkEventModel parkEventModel = new ParkEventModel();
            parkEventModel.ParkName = parkName;

            return View(parkEventModel);
        }

        public IActionResult UpdateParkIndexRazor()
        {
            Console.WriteLine("UPDATE PARK INDEX");
            ViewBag.Parks = QueryParks(ALL_PARKS);
            return View();
        }
    }
}