using System;
using System.Collections.Generic;

namespace Parks_SpecialEvents.Models
{
    public class AzureParkImages
    {
        public string ParkID { get; set; }
        public List<string> Images { get; set; }
        public AzureParkImages()
        {
            this.Images = new List<string>();
        }
    }
}
