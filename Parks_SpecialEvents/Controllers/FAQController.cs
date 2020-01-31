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
        //const string PARKSCONNECTIONSTRING = @"Data Source=LAPTOP-M67PUJ2M;Initial Catalog=parks_faqDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        const string PARKSCONNECTIONSTRING = @"data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";

        // STORE PARKS IN A DATABASE
        ParkDB parkDB = new ParkDB();

        const string QUERY_FOR_ALL_PERMIT_PARKS = "SELECT DISTINCT Parks.ParkID, ParkName, Lat, Lng, Image, Event_Name, Flag" +
                  " FROM Event" +
                  " INNER JOIN Event_Info ON" +
                  " Event.EventID = Event_Info.EventID" +
                  " INNER JOIN Parks ON" +
                  " Parks.ParkID = Event.ParkID" +
                  " Where Flag = 1";

        // QUERY FOR ALL QUESTIONS
        const string ALL_QUESTIONS = "SELECT * FROM Questions;";
        const string ALL_VISIBLE_QUESTIONS = "SELECT * FROM Questions WHERE ShownFlag = 1;";

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
     
        // GET: /<controller>/
        public IActionResult Index()
        {
            // STORE IN VIEWBAG


            ViewBag.storing = QueryQuestions(ALL_VISIBLE_QUESTIONS);

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

            ViewBag.storing = QueryQuestions($"SELECT * FROM Questions WHERE ShownFlag = 1 AND Question LIKE '%{search}%';");

            if (questionDB.Size == 0)
            {
                Console.WriteLine($"NO RESULTS FOUND FOR: {search}");
                Console.WriteLine("REDIRECTING TO INDEX PAGE");
                return RedirectToAction("Index");
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
