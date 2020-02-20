using System;
using System.Collections.Generic;

namespace Parks_SpecialEvents.Models
{
    public class EventType
    {
        public string Name { get; set; }

        public List<Event> eventList = new List<Event>();

        public List<ParkThumbnail> distinctParkList = new List<ParkThumbnail>();
   
        public static IEnumerable<Event> EventList
        {
            get { return EventList; }
        }
        public EventType(string n)
        {
            this.Name = n;
        }

        public void AddToList(Event e)
        {
            eventList.Add(e);
        }

        public void AddParkThumbnail(ParkThumbnail pt)
        {
            distinctParkList.Add(pt);
        }
    }
}
