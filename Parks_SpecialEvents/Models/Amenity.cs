using System;
namespace Parks_SpecialEvents.Models
{
    public class Amenity
    {
        public int AmenityID { get; set; }
        public string ParkID { get; set; }
        public string Amen { get; set; }
        public int Quanity { get; set; }
        public string Image { get; set; }
        public bool Flag { get; set; }

        public Amenity(){ }

        public Amenity(int amenityID, string parkID, string amenity, int quanity, string image)
        {
            AmenityID = amenityID;
            ParkID = parkID;
            Amen = amenity;
            Quanity = quanity;
            Image = image;
        }
    }
}
