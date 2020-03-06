using System;
using System.Collections.Generic;

namespace Parks_SpecialEvents.Models
{
    public class AzureMasterPark
    {
        public AzurePark AzurePark { get; set; }
        public AzureParkImages AzureParkImages { get; set; }
        public List<Amenity> Amenitys { get; set; }
        public ParkEventModel Events { get; set; }

        public AzureMasterPark()
        {
            this.AzurePark = new AzurePark();
            this.AzureParkImages = new AzureParkImages();
            this.Amenitys = new List<Amenity>();
            this.Events = new ParkEventModel();
        }
    }
}
