using System;
using System.Collections.Generic;

namespace Parks_SpecialEvents.Models
{
    public class ParkImageDB
    {
        public int Size { get; set; }
        public List<Image> images = new List<Image>();
        
        public static IEnumerable<Image> Images { get { return Images; } }

        public void Add(Image i)
        {
            Size++;
            images.Add(i);
            
        }
    }
}
