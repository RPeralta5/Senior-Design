using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAQSearch.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }

        public QuestionModel(int id, string questionText, string answerText)
        {
            this.Id = id;
            this.QuestionText = questionText;
            this.AnswerText = answerText;
        }
    }

}