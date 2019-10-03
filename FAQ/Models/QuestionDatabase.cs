using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAQSearch.Models
{
    public class QuestionDatabase
    {
        public List<QuestionModel> questions = new List<QuestionModel>();

        public static IEnumerable<QuestionModel> Questions {get;set;}

        public void AddQuestion(QuestionModel q)
        {
            questions.Add(q);
        }
        public bool contains(string str)
        {
            foreach(QuestionModel q in questions) 
            {
                if(q.QuestionText.Contains(str) || q.AnswerText.Contains(str))
                {
                    return true;
                }
            }
            return false;
        }
    }
}