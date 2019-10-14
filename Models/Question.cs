﻿using System;
namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Q { get; set; }
        public string Answer { get; set; }
        public DateTime Date { get; set; }
        public Question(int id, string q, string answer, DateTime date)
        {
            this.ID = id;
            this.Q = q;
            this.Answer = answer;
            this.Date = date;
        }
    }
}