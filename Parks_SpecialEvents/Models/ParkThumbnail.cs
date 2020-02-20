using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parks_SpecialEvents.Models
{
    public class ParkThumbnail
    {
        public string Image { get; set; }
        public string ParkName { get; set; }
        public string ID { get; set; }
        public ParkThumbnail(string id, string parkName, string image)
        {
            this.ID = id;
            this.ParkName = parkName;
            this.Image = image;
        }
    }
}
