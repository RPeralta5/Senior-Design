using System;
namespace Parks_SpecialEvents.Models
{
    public class Registration
    {
        public string EventName { get; set; }
        public bool Alcohol { get; set; }

        public string NameInsured { get; set; }

        public Registration(string eventName, bool alcohol, string nameInsured)
        {
            this.EventName = eventName;
            this.Alcohol = alcohol;
            this.NameInsured = nameInsured;

        }
    }
}
