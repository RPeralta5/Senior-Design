using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parks_SpecialEvents.Models;
//using Parks_SpecialEvents.Models;
using System.Data.SqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parks_SpecialEvents.Controllers
{
    public class FAQController : Controller
    {
        // STORE QUESTIONS IN A DATABASE
        QuestionDB questionDB = new QuestionDB();

        // PARKS CONNECTION STRING
        const string PARKSCONNECTIONSTRING = "data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";

        // STORE PARKS IN A DATABASE
        ParkDB parkDB = new ParkDB();

        // STORE PERMITABLES ONLY
        List<Event> permitableDB = new List<Event>();

        // QUERY FOR ALL PERMIT PARKS
        const string QUERY_FOR_ALL_PERMIT_PARKS = "SELECT DISTINCT Parks.ParkID, ParkName, Lat, Lng, Image, Event" +
                " FROM Parks, Events" +
                " WHERE Parks.ParkID = Events.ParkID;"; 

        // QUERY FOR ALL QUESTIONS
        const string ALL_QUESTIONS = "SELECT * FROM Questions;";

        /*   PERMITABLES ARE THE BUTTONS AT THE VERY TOP WHICH SHOW YOU WHICH PARKS CAN DO
         *   CERTAIN THINGS
        */
        const string PERMITABLES = "SELECT DISTINCT Event, Href FROM Events"; // used to end in ;

        private QuestionDB QueryQuestions(string query)
        {
            // CONNECT TO DATABASE
            using(SqlConnection sqlConnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
                // COMMAND TO EXECUTE
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN THE SQL CONNECTION
                sqlConnection.Open();

                //READ THE DATA
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        questionDB.AddQuestion(new Question((int)reader[0], (string)reader[1],
                            (string)reader[2], (DateTime)reader[3], (bool) reader[4]));
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }

            return questionDB;
        }

        private ParkDB QueryParks(string query)
        {
            // CONNECT TO PARKS DATABASE
            using(SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
                // COMMAND TO EXECUTE
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                // OPEN SQL CONNECTION
                sqlConnnection.Open();
  
                // READ DATA
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        // Parks.ParkID, ParkName, Lat, Lng, Image, Event

                        //string id, string parkName, string address, double lat, double lng, string image, string permitables
                        parkDB.AddPark(new Park((string)reader[0], (string)reader[1], "",
                        (double)reader[2], (double)reader[3], (string)reader[4],
                        (string) reader[5]));
                    }
                }

                foreach(Park p in parkDB.parks)
                {
                    Console.WriteLine($"Permitables: {p.Permitables}");
                }
                Console.WriteLine($"SIZE OF PARK DATABASE: {parkDB.Size}");

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }
            return parkDB;
        }

        private List<Event> QueryPermitables(string query)
        {
            // CONNECT TO PARKS DATABASE
            using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
                // COMMAND TO EXECUTE
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                // OPEN SQL CONNECTION
                sqlConnnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Parks.ParkID, ParkName, Lat, Lng, Image, Event
                        //Console.WriteLine($"PermitID: {reader[0]} ParkID: {reader[1]}, Permitable: {reader[2]} Href: {reader[3]}");
                        permitableDB.Add(new Event((string)reader[0],
                            (string)reader[1], true));
                    }
                }

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }
            return permitableDB;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            // STORE IN VIEWBAG
            ViewBag.storePermitables = QueryPermitables(PERMITABLES);

            ViewBag.storeParks = QueryParks(QUERY_FOR_ALL_PERMIT_PARKS);

            ViewBag.storing = QueryQuestions(ALL_QUESTIONS);

            return View();
        }

        public IActionResult Question(string question)
        {
            // STORE IN VIEWBAG
            ViewBag.storing = QueryQuestions($"SELECT * FROM Questions WHERE Question='{question}';");
            return View();
        }   

        public IActionResult Search(string search)
        {
            // IF VALIDATION FALSE DROP AND EJECT WE HAVE AN INTRUDER!
            if(validate(search) == false)
            {
                Console.WriteLine("SEARCH WAS NULL REDIRECT TO FAQ INDEX PAGE");
                return RedirectToAction("Index");
            }

            // STORE IN VIEWBAG
            ViewBag.storePermitables = QueryPermitables(PERMITABLES + $" WHERE Event LIKE '%{search}%'");

            ViewBag.storeParks = QueryParks(QUERY_FOR_ALL_PERMIT_PARKS);

            ViewBag.storing = QueryQuestions($"SELECT * FROM Questions WHERE Question LIKE '%{search}%';");

            if (questionDB.Size == 0 && permitableDB.Count == 0)
            {
                Console.WriteLine($"NO RESULTS FOUND FOR: {search}");
                Console.WriteLine("REDIRECTING TO INDEX PAGE");
                return RedirectToAction("Index");
            } else if (questionDB.Size == 0) {
                Console.WriteLine("ZERO RESULTS FOR QUESTIONS");
                Console.WriteLine("GONNA DISPLAY ALL QUESTIONS AS DEFAULT");
                ViewBag.storing = QueryQuestions(ALL_QUESTIONS);
            } else if(permitableDB.Count == 0)
            {
                Console.WriteLine("ZERO RESULTS FOR PERMITABLES");
                Console.WriteLine("GOING TO DISPALY ALL PERMITABLES AS DEFAULT");
                ViewBag.storePermitables = QueryPermitables(PERMITABLES);
            }
            return View();
        }

        private bool validate(string search)
        {
            List<string> keyWords = new List<string>();
            keyWords.Add("DELETE");
            keyWords.Add("UPDATE");
            keyWords.Add("SELECT");
            keyWords.Add("*");
            keyWords.Add("DROP");
            keyWords.Add("DROP TABLE");
            keyWords.Add(";");
      
            if(search == "" || search == null)
            {
                return false;
            }

            // IF KEYWORD IS FOUND RETURN FALSE
            foreach (string keyword in keyWords) {

                Console.WriteLine($"KEYWORDS: {keyword}");
                if(search.ToUpper().Contains(keyword))
                {
                    Console.WriteLine($"KEY WORD FOUND: {keyword}");
                    return false;
                }
            }

            return true;
        }
    }
}
