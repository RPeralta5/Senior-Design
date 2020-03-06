
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Parks_SpecialEvents.Models
{
    public class AzureParkImages
    {
        public string ParkID { get; set; }
        public List<IFormFile> Images { get; set; }
        public List<string> ImagesPath { get; set; }

        public AzureParkImages()
        {
            this.Images = new List<IFormFile>();
            this.ImagesPath = new List<string>();
        }
    }
}
