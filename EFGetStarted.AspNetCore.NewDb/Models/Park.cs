using System;
namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class Park
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Permitables { get; set; }
        public string Image { get; set; }
        public Park(int id, string address, double lat, double lng, string image, string permitables)
        {
            this.ID = id;
            this.Address = address;
            this.Lat = lat;
            this.Lng = lng;
            this.Image = image;
            this.Permitables = permitables;
        }
    }
}
