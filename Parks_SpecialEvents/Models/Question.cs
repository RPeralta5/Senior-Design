using System;
namespace Parks_SpecialEvents.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Q { get; set; }
        public string Answer { get; set; }
        public DateTime Date { get; set; }
        public bool Flag { get; set; }

        public Question() { } // Empty Constructor used for creating models
        public Question(int id, string q, string answer, DateTime date, bool flag)
        {
            this.ID = id;
            this.Q = q;
            this.Answer = answer;
            this.Date = date;
            this.Flag = flag;
        }
    }
}
