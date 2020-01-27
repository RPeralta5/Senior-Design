using System;
using System.Collections.Generic;

namespace Parks_SpecialEvents.Models
{
    public class ParkDB
    {
        public int Size { get; set; }
        public List<Park> parks = new List<Park>();

        public static IEnumerable<Park> Parks
        {
            get { return Parks; }
        }

        public void AddPark(Park p)
        {
            this.Size++;
            parks.Add(p);
        }

    }
}
