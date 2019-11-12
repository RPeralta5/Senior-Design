using System;
namespace Parks_SpecialEvents.Models
{
    public class Event
    {
        public string P { get; set; }
        public string Href { get; set; }
        public bool Flag { get; set; }
      
        public Event(string p, string href, bool flag)
        {
            this.P = p;
            this.Href = href;
            this.Flag = flag;
        }
    }
}
