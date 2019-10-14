using System;
namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class Permitable
    {
        public string P { get; set; }
        public string Href { get; set; }
        public Permitable(string p, string href)
        {
            this.P = p;
            this.Href = href;
        }
    }
}
