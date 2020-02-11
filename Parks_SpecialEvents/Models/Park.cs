using System;
namespace Parks_SpecialEvents.Models
{
    public class Park
    {
        public string ID { get; set; }
        public string ParkName { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Event { get; set; }
        public string Image { get; set; }
        public bool Flag { get; set; }
        public string Phone { get; set; }

        public Park(string id, string parkName, string address, double lat, double lng, string image, string e, bool flag)
        {
            this.ID = id;
            this.ParkName = parkName;
            this.Address = address;
            this.Lat = lat;
            this.Lng = lng;
            this.Image = image;
            this.Event = e;
            this.Flag = flag;
        }
    }
}
