using FAQSearch.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FAQSearch.Controllers
{
    public class FAQController : Controller
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master";
        QuestionDatabase qdb = new QuestionDatabase();
        // GET: FAQ
        public ActionResult Index()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM questions";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        qdb.AddQuestion(new QuestionModel((int) reader[0], (string) reader[1], (string) reader[2]));
                    }
                }
                sqlConnection.Close();
            }
            ViewBag.storing = qdb;
                return View();
        }
    }
}