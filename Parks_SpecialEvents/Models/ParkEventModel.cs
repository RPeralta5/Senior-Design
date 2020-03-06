using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Parks_SpecialEvents.Models
{
    public class ParkEventModel
    {
        public string ParkName { get; set; }
        public List<Event> Events { get; set; }
   
    }
}
