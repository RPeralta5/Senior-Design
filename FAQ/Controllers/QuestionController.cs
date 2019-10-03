using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FAQSearch.Models
{
    public class QuestionController : Controller
    {
        List<QuestionModel> questions = new List<QuestionModel>();
        // GET: Questions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListQuestion()
        {
            /*
             questions.Add(new QuestionModel { QuestionText = "Who Are You?", AnswerText = "Francis Nguyen" });
            questions.Add(new QuestionModel { QuestionText = "How old are you?", AnswerText = "22" });
            questions.Add(new QuestionModel { QuestionText = "What is your favorite color?", AnswerText = "Green" });
             */
            return View(questions);
        }
      }
}