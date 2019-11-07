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
        // CONNECTION STRING
        string cString = "data source=.; database= FAQ; user id = sa; password = myPassw0rd";

        // STORE DATA
        QuestionDB questionDB = new QuestionDB();
       
        // GET: /<controller>/
        public IActionResult Index()
        {

            using(SqlConnection sqlConnection = new SqlConnection(cString))
            {
                // COMMAND TO EXECUTE
                string command = "SELECT * FROM Questions;";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN THE CONNECTION
                sqlConnection.Open();

                // READ THE DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        questionDB.AddQuestion(new Question( (int) reader[0], (string) reader[1],
                            (string) reader[2], (DateTime) reader[3] ));
                    }
                }
                // CLOSE THE CONNECTION
                sqlConnection.Close();
            }
            // STORE IN VIEWBAG
            //ViewData["question"] = question;
           ViewBag.storing = questionDB;
            return View();
        }

        public IActionResult Question(string question)
        {
            Console.WriteLine($"IDD: {question}");
            using (SqlConnection sqlConnection = new SqlConnection(cString))
            {
                // SQL COMMAND
                string command = $"SELECT * FROM Questions WHERE Question='{question}';";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        questionDB.AddQuestion(new Question((int)reader[0], (string)reader[1],
                        (string)reader[2], (DateTime)reader[3]));
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            // STORE IN VIEWBAG
            ViewBag.storing = questionDB;
            return View();
        }

        //public IActionResult Question(Question question)
        //{
        //    Console.WriteLine($"Question: {question.Q}");
        //    using (SqlConnection sqlConnection = new SqlConnection(cString))
        //    {
        //        // SQL COMMAND
        //        string command = $"SELECT * FROM Questions WHERE Question={question.Q};";
        //        SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

        //        // OPEN CONNECTION
        //        sqlConnection.Open();

        //        // READ DATA
        //        using (SqlDataReader reader = sqlCommand.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                questionDB.AddQuestion(new Question((int)reader[0], (string)reader[1],
        //                (string)reader[2], (DateTime)reader[3]));
        //            }
        //        }
        //        // CLOSE CONNECTION
        //        sqlConnection.Close();
        //    }
        //    // STORE IN VIEWBAG
        //    ViewBag.storing = questionDB;
        //    return View();
        //}

        public IActionResult Search(string search)
        {
            using (SqlConnection sqlConnection = new SqlConnection(cString))
            {
                // SQL COMMAND
                string command = $"SELECT * FROM Questions WHERE Question LIKE '%{search}%';";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        questionDB.AddQuestion(new Question((int)reader[0], (string)reader[1],
                        (string)reader[2], (DateTime)reader[3]));
                    }
                }
                // CLOSE CONNECTION
                sqlConnection.Close();
            }
            // STORE IN VIEWBAG
           // ViewData["Question"] = search;
            ViewBag.storing = questionDB;
            return View();
        }
    }
}
