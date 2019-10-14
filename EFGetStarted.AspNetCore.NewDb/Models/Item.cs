using System;
namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string ArtistName { get; set; }
        public DateTime ActiveFrom { get; set; }

        public Item(int id, string name, DateTime active)
        {
            this.ID = id;
            this.ArtistName = name;
            this.ActiveFrom = active;
        }
    }
}
