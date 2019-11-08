using System;
namespace Parks_SpecialEvents.Models
{
    public class Event
    {
        public string P { get; set; }
        public string Href { get; set; }
        public int Flag { get; set; }
      
        public Event(string p, string href, int flag)
        {
            this.P = p;
            this.Href = href;
            this.Flag = flag;
        }
    }
}
