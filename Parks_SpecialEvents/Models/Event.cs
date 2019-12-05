using System;
namespace Parks_SpecialEvents.Models
{
    public class Event
    {
        public string E { get; set; }
        public string Href { get; set; }
        public bool Flag { get; set; }
      
        public Event(string e, string href, bool flag)
        {
            this.E = e;
            this.Href = href;
            this.Flag = flag;
        }
    }
}
