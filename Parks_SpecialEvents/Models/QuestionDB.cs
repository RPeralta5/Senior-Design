using System;
using System.Collections.Generic;

namespace Parks_SpecialEvents.Models
{
    public class QuestionDB
    {
    
        public int Size { get; set; }
        public List<Question> questions = new List<Question>();

        public static IEnumerable<Question> Questions
        {
            get { return Questions; }
        }

        public void AddQuestion(Question q)
        {
            this.Size++;
            questions.Add(q);
        }
    }
}
