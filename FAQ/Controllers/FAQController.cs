using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFGetStarted.AspNetCore.NewDb.Models;
using System.Data.SqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
    public class FAQController : Controller
    {
        // FAQ CONNECTION STRING
        const string FAQCONNECTIONSTRING = "data source=.; database= FAQ; user id = sa; password = myPassw0rd";

        // STORE QUESTIONS IN A DATABASE
        QuestionDB questionDB = new QuestionDB();

        // PARKS CONNECTION STRING
        const string PARKSCONNECTIONSTRING = "data source=.; database= Parks; user id = sa; password = myPassw0rd";

        // STORE PARKS IN A DATABASE
        ParkDB parkDB = new ParkDB();

        // STORE PERMITABLES ONLY
        List<Permitable> permitableDB = new List<Permitable>();

        const string QUERY_FOR_ALL_PERMIT_PARKS = "SELECT DISTINCT Parks.ParkID, Address, Lat, Lng, Image, Permitable" +
                " FROM Parks, Permitables" +
                " WHERE Parks.ParkID = Permitables.ParkID; ";

        /*   PERMITABLES ARE THE BUTTONS AT THE VERY TOP WHICH SHOW YOU WHICH PARKS CAN DO
         *   CERTAIN THINGS
        */
        const string PERMITABLES = "SELECT DISTINCT Permitable, Href FROM Permitables;";

        private QuestionDB QueryQuestions(string query)
        {
            // CONNECT TO DATABASE
            using(SqlConnection sqlConnection = new SqlConnection(FAQCONNECTIONSTRING))
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
                            (string)reader[2], (DateTime)reader[3]));
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
                        parkDB.AddPark(new Park((int)reader[0], (string)reader[1],
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

        private List<Permitable> QueryPermitables(string query)
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
                        permitableDB.Add(new Permitable((string) reader[0],
                            (string) reader[1]));
                    }
                }

                foreach (Permitable p in permitableDB)
                {
                    Console.WriteLine($"HREF: {p.Href}");
                }
                Console.WriteLine($"SIZE OF PERMITABLES: {permitableDB.Count}");

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

            ViewBag.storing = QueryQuestions("SELECT * FROM Questions;");

            return View();
        }

        public IActionResult Question(string question)
        {
            QueryQuestions($"SELECT * FROM Questions WHERE Question='{question}';");

            // STORE IN VIEWBAG
            ViewBag.storing = questionDB;
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
            Console.WriteLine($"SEARCH: {search}");
            QueryParks(QUERY_FOR_ALL_PERMIT_PARKS);
            QueryQuestions($"SELECT * FROM Questions WHERE Question LIKE '%{search}%';");

            // STORE IN VIEWBAG
            ViewBag.storing = questionDB;
            ViewBag.storeParks = parkDB;
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
      
            if(search == "" || search == null)
            {
                return false;
            }

            // IF KEYWORD IS FOUND RETURN FALSE
            foreach (string keyword in keyWords) {

                Console.WriteLine($"KEYWORDS: {keyword}");
                if(search.ToUpper().Contains(keyword))
                {
                    Console.WriteLine($"KEY WORD FOUND {keyword}");
                    return false;
                }
            }

            return true;
        }
    }
}
