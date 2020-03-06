using System;
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
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parks_SpecialEvents.Controllers
{
    public class AdminController : Controller
    {

        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IConfiguration _config;

        public AdminController(IHostingEnvironment e, IConfiguration config)
        {
            hostingEnvironment = e;
            _config = config;
        }

        private string PARK_DB_CONNECTION
        {
            get { return _config.GetValue<string>("ConnectionString:default"); }
        }

        // THESE ARE USED FOR REUSE : NO NEED TO QUERY TWICE
        private static string staticParkID;
        private static List<Event> originalEvents;


        // PARKS DATABASE CONNECTION STRING
        //const string PARK_DB_CONNECTION = @"Data Source=LAPTOP-M67PUJ2M;Initial Catalog=parks_faqDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //const string PARK_DB_CONNECTION = @"data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";

        // QUERY FOR ALL PARKS
        const string ALL_PARKS = "SELECT ParkID, ParkName, Address, Lat, Lng FROM Parks;";

        // QUERY FOR ALL EVENTS
        const string ALL_EVENTS = "SELECT Event_Name FROM Event_Info;";

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
                            (double) reader[3], (double) reader[4], "", "", false));
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

                        events.Add(new Event((string)reader[0], "",
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

            // IF THE PARK DOES NOT HOLD ANY EVENTS, SET ALL EVENTS TO FALSE
            if(heldByPark.Count == 0)
            {
                foreach(Event notHeld in allEvents)
                {
                    events.Add(new Event(notHeld.E, "", false));
                }
                return events;
            }

            foreach(Event all in allEvents)
            {
                int count = 0;
               
                foreach (Event held in heldByPark)
                {
                    if(held.E == all.E)
                    {
                        //Console.WriteLine($"{all.E} is HELD BY PARK");
                        events.Add(new Event(all.E, all.Href, true));
                        break;
                    }
                    if(count == heldByPark.Count - 1)
                    {
                        //Console.WriteLine($"{all.E} is NOT HELD BY PARK");
                        events.Add(new Event(all.E, all.Href, false));
                    }
                    count++;
                }
            }
            Console.WriteLine(events.Count);
            return events;
        }

        private int getEventID(string e)
        {
            int eventID = -1;
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string command = $"SELECT EventID FROM Event_Info WHERE Event_Name = '{e}';";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // READ DATA
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        eventID = (int) reader[0];
                    }
                }
                // CLOSE SQL CONNECTION
                sqlConnection.Close();
            }
            return eventID;
        }

        private void UpdateParkEvent(string e)
        {
            Console.WriteLine($"TURNING ON EVENT: {e}");
            int eventID = getEventID(e);

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXACUTE
                string command = "UPDATE Event SET Flag = 1 " +
                    $"WHERE ParkID = '{staticParkID}' AND EventID = {eventID};";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // EXECUTE COMMAND
                sqlCommand.ExecuteReader();

                // CLOSE SQL CONNECTION
                sqlConnection.Close();
            }
            
        }

        private void TurnOffAllEventsForPark(string parkID)
        {
            Console.WriteLine($"TURNED OFF ALL EVENTS FOR {parkID}");

            // CONNECTING TO THE DATABASE
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND T0 EXECUTE
                string command = $"UPDATE Event SET Flag = 0 WHERE ParkID = '{parkID}' AND Flag = 1;";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // UPDATE TABLE
                sqlCommand.ExecuteReader();

                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            Console.WriteLine($"ALL EVENTS FOR {parkID} have been turned off");
        }

        [HttpPost]
        public IActionResult EditPark(AzureMasterPark azureMasterPark) // used to accept parkEventModel
        {
            Console.WriteLine("PARK EVENT MODEL");
            Console.WriteLine($"ParkName: {azureMasterPark.AzurePark.ParkName}");

            // get all lists: Amenitites and Events
            var updatedAmenities = Request.Form["AMENITIES"];
            var updatedEvents = Request.Form["EVENTS"];

            Console.WriteLine($"UPDATED AMENITIES: {updatedAmenities}");
            Console.WriteLine($"UPDATED EVENTS: {updatedEvents}");

            // SET ALL PARK EVENTS TO FLAG : TURRN OFF EVENTS
            TurnOffAllEventsForPark(staticParkID);

            // TURN ON ALL NEW : UPDATED EVENTS
            foreach (String e in updatedEvents)
            {
                Console.WriteLine($"EVENTS FROM EDIT PARK: {e}");
                UpdateParkEvent(e);
            }
            Console.WriteLine("PARK HAS BEEN UPDATED!");
            return RedirectToAction("UpdateParkIndexRazor");
        }

        [HttpGet]
        public IActionResult UpdateParkRazor(string parkID)
        {
            staticParkID = parkID;

            // PARK NAME
            string parkName = GetParkNameByID(parkID);
            ViewBag.ParkName = parkName;

            // GET ALL EVENTS
            List<Event> allEvents = QueryEvents(ALL_EVENTS);
    
            // EVENTS HELD BY PARK
            string eventsHeldByPark = "SELECT Event_Name FROM Event_Info, Event " +
                            $"WHERE ParkID = '{staticParkID}' " + 
                            "AND Flag = 1 AND Event.EventID = Event_Info.EventID;";
            List<Event> heldByPark = QueryEvents(eventsHeldByPark);
            originalEvents = heldByPark;

            List<Event> list = filter(allEvents, heldByPark);

            AzureMasterPark azureMasterPark = new AzureMasterPark();

            ParkEventModel parkEventModel = new ParkEventModel();
            parkEventModel.ParkName = parkName;
            parkEventModel.Events = list;

            QueryParks queryParks = new QueryParks(hostingEnvironment);
            QueryAmenities queryAmenities = new QueryAmenities();
            QueryParkImages queryParkImages = new QueryParkImages(hostingEnvironment);
            AzureParkImages azureParkImages = new AzureParkImages();

            // all amenities
            List<Amenity> amenities = queryAmenities.filterAmenitys(queryAmenities.getAmenitiesFrom(parkID), queryAmenities.GetAmenities());
            
            // add everything to AZURE MASTER PARK
            azureMasterPark.AzurePark = queryParks.getParkInfo(parkID);
            azureMasterPark.Amenitys = amenities;
            azureMasterPark.AzureParkImages.ImagesPath = queryParkImages.getImagesPath(parkID);
            azureMasterPark.Events = parkEventModel;

            return View(azureMasterPark); // used to be parkEventModel
        }

        public IActionResult UpdateParkRazorConfirmation(AzureMasterPark azureMasterPark)
        {
            Console.WriteLine("INSIDE UPDATE PARK CONFIRMATION METHOD");
            // update park
            Console.WriteLine($"HOSTING ENVIRONMENT: {hostingEnvironment.WebRootPath}");
            QueryParks queryParks = new QueryParks(hostingEnvironment);
            try
            {
                queryParks.UpdatePark(azureMasterPark);
                Console.WriteLine("UPDATED PARK!");
            } catch(Exception e)
            {
                Console.WriteLine("DID NOT UPDATE PARK");
                Console.WriteLine($"error: {e}");
            }

            // sent to confirmation
            return View(azureMasterPark);
        }

        public IActionResult UpdateParkIndexRazor()
        {
            Console.WriteLine("UPDATE PARK INDEX");
            ViewBag.Parks = QueryParks(ALL_PARKS);
            return View();
        }

        public IActionResult SelectQuestion(string s = "ALL")
        {
            QuestionDB questions = new QuestionDB();
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string query = "SELECT * FROM Questions;";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        questions.AddQuestion(new Question((int) reader[0], (string) reader[1], (string) reader[2],
                            (DateTime) reader[3], (bool) reader[4]) );
                    }
                }
            }
            Console.WriteLine($"QUESTION DB SIZE: {questions.Size}");
            ViewBag.QDB = questions;
            ViewBag.show = s;
            return View();
        }

        public IActionResult EditQuestionRazorPage(int id)
        {
            Console.WriteLine($"QUESTION ID: {id}");
            Question question = null;
            // GET THE QUESTION FROM USING PROVIDED ID
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // QUERY TO EXECUTE
                string query = "SELECT * FROM Questions " +
                                    $"WHERE QuestionID = {id};";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // READ DATA
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        question = new Question((int) reader[0], (string) reader[1], (string) reader[2],
                            (DateTime) reader[3], (bool) reader[4]);
                    }
                }

                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            ViewBag.Q = question;
            return View();
        }

        public IActionResult UpdateQuestion(Question question)
        {
            int flag = -1;
            if(question.Flag == false)
            {
                flag = 1;
            } else
            {
                flag = 0;
            }
            // UPDATE QUESTION
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // QUERY TO EXECUTE
                string query = $"UPDATE Questions SET Question = '{question.Q}'," + 
                        $" Answer = '{question.Answer}'," +
                        $" ShownFlag = {flag} WHERE QuestionID = {question.ID};";

                Console.WriteLine(query);
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // EXECUTE COMMAND
                command.ExecuteReader();

                // CLOSE CONNECTION
                sqlConnection.Close();
            }

            return RedirectToAction("SelectQuestion");
        }

        public IActionResult AddQuestionRazor()
        {
            Console.WriteLine("INSIDE ADD QUESTION RAZOR");
            return View();
        }

        public IActionResult AddQuestion(Question question)
        {
            Console.WriteLine("INSIDE ADD QUESTION METHOD");
            // SET UP CONNECTION
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                int flag = 1;
                if(question.Flag == true)
                {
                    flag = 0;
                }
                // QUERY TO EXECUTE
                string query = "INSERT INTO Questions (Question, Answer, ShownFlag)" +
                    $" VALUES('{question.Q}', '{question.Answer}', {flag}); ";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // ADD QUESTION
                command.ExecuteReader();

                // CLOSE CONNECTION
                sqlConnection.Close();
            }

            return RedirectToAction("SelectQuestion");
        }

        public IActionResult DeleteQuestionRazorConfirmation(int id)
        {
            Question q = null;
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // GET QUESTION
                string query = "SELECT * FROM Questions" +
                    $" WHERE QuestionID = {id};";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        // id, question, answer, date, flag
                        bool flag = true;
                        if((Boolean)reader[4] == true)
                        {
                            flag = false;
                        }

                        q = new Question((int) reader[0], (string) reader[1], (string) reader[2],
                            (DateTime) reader[3], flag);
                    }
                }

                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            ViewBag.Question = q;
            return View();
        }

        public IActionResult DeleteQuestion(int id)
        {
            Console.WriteLine($"DELETE QUESTION WITH ID {id}");

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // QUERY TO EXECUTE
                string query = "DELETE FROM Questions" +
                        $" WHERE QuestionID = {id};";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // DELETE QUESTION
                command.ExecuteReader();

                // CLOSE SQL CONNECTION
                sqlConnection.Close();

            }

            return RedirectToAction("SelectQuestion");
        }

        public IActionResult AddParkRazor()
        {
            List<string> amenities = new List<string>();
            // GET ALL AMENITIES
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // QUERY
                string query = "SELECT DISTINCT Amenity FROM Amenities;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // int amenityID, string parkID, string amenity, int quanity, string image
                        amenities.Add((string)reader[0]);
                    }
                }

                // CLOSE SQL CONNECTION
                sqlConnection.Close();
            }
            
            ViewBag.storeAmenities = amenities;
            return View();
        }

        public IActionResult AddPark(AzurePark park)
        {
            Console.WriteLine("add park method");

            // put image into parkthumbnails
            var destination = Path.Combine(hostingEnvironment.WebRootPath + "/images/ParkThumbnails", park.Image.FileName);
            // put image there
            park.Image.CopyTo(new FileStream(destination, FileMode.Create));

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // QUERY
                string query = "INSERT INTO Parks (ParkID, ParkName, ParkLastName, Address, Street_Number, Street_Name, City, Zip, FacilityPhone, Lat, Lng, GIS_Acres, Inventory_Acres, Image)" +
                        " VALUES " +
                        $"('{park.ParkID}', '{park.ParkName}', '{park.ParkLastName}', '{park.Address}','{park.StreetNumber}','{park.StreetName}', '{park.City}', '{park.Zip}','{park.FacilityPhone}', {park.Lat}, {park.Lng}, {park.GISAcres}, {park.InventoryAcres}, '/images/ParkThumbnails/{park.Image.FileName}');";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // EXECUTE QUERY
                sqlCommand.ExecuteReader();

                // CLOSE CONNECTION
                sqlConnection.Close();

            }
            return RedirectToAction("AddAmenitiesToParkRazor", park);
        }

        public IActionResult AddAmenitiesToParkRazor(AzurePark park)
        {
            Console.WriteLine("Add Amenities to Park: " + park.ParkID);
            Console.WriteLine($"ParkID: {park.ParkName}");

            QueryAmenities queryAmenities = new QueryAmenities(hostingEnvironment);

            ViewBag.amenities = queryAmenities.getAmenities();
            Console.WriteLine($"number of amenities: {queryAmenities.getAmenities().Count}");
            ViewBag.park = park;
            return View(park);
        }

        public IActionResult AddAmenitiesToPark(string parkID) // string parkID
        {
            
            var amenities = Request.Form["AMENITIES"];
            
            List<string> a = new List<string>();
            foreach(string amenity in amenities)
            {
                a.Add(amenity);
                Console.WriteLine(amenity);
            }
            Console.WriteLine($"amenity size: {a.Count}");

            // add amenities to park
            QueryAmenities queryAmenities = new QueryAmenities();
            queryAmenities.addAmenities(parkID, a);
            Console.WriteLine("GONNA TRY TO REDIRECT");
            
            return RedirectToAction("AddParkImagesRazor", new { parkID = parkID}); // new { parkID = parkID }
        }

        public IActionResult AddParkImagesRazor(string parkID) 
        {
            Console.WriteLine("Add Park Images mEhtod");
            Console.WriteLine($"PARKID : {parkID}");
            ViewData["parkID"] = parkID;
            return View();
        }

        public IActionResult AddParkImages(AzureParkImages parkImages)
        {
            Console.WriteLine($"adding images to {parkImages.ParkID}");

            QueryParkImages queryParkImages = new QueryParkImages(hostingEnvironment);
            queryParkImages.addImages(parkImages);

            return RedirectToAction("AddParkEventRazor", new { parkID = parkImages.ParkID });
        }

        public IActionResult AddParkEventRazor(string parkID)
        {
            QueryEventInfo queryEventInfo = new QueryEventInfo();
            ViewBag.events = queryEventInfo.getDistinctEvents();
            ViewData["parkID"] = parkID;
            return View();
        }

        public IActionResult AddParkEvents(string parkID)
        {
            Console.WriteLine($"Add Events for parkID: {parkID}");

            var temp = Request.Form["EVENTS"];
            List<string> events = new List<string>();

            foreach(string e in temp)
            {
                events.Add(e);
            }

            QueryEvents queryEvents = new QueryEvents();
            queryEvents.addEvents(events, parkID);

            return RedirectToAction("AddParkConfirmation", new { parkID = parkID});
        }

        public IActionResult AddParkConfirmation(string parkID)
        {
            ViewData["parkID"] = parkID;
            return View();
        }

        public IActionResult AdminParkRazor()
        {
            QueryParks queryParks = new QueryParks();
            List<AzurePark> parks = queryParks.getParkIDAndParKName();

            ViewBag.parks = parks;
            return View();
        }

        public IActionResult DeleteParkRazor(string parkID)
        {
            QueryParks queryParks = new QueryParks();
            ViewData["parkID"] = parkID;
            ViewData["parkName"] = queryParks.getParkName(parkID);
            return View();
        }

        public IActionResult DeletePark(string parkID)
        {
            QueryParks queryParks = new QueryParks(hostingEnvironment);
            queryParks.DeletePark(parkID);

            return RedirectToAction("DeleteParkConfirmation", new { parkID = parkID });
        }

        public IActionResult DeleteParkConfirmation(string parkID)
        {
            QueryParks queryParks = new QueryParks(hostingEnvironment);
            ViewData["parkID"] = parkID;
            ViewData["parkName"] = queryParks.getParkName(parkID);
            return View();
        }
    }
}
