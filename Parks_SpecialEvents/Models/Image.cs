using System;
namespace Parks_SpecialEvents.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string ParkID { get; set; }
        public string ImagePath { get; set; }

        public Image() { }
        public Image(int imageID, string parkID, string imagePath)
        {
            this.ImageID = imageID;
            this.ParkID = parkID;
            this.ImagePath = imagePath;
        }
    }
}
