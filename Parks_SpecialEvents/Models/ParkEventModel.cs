using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Parks_SpecialEvents.Models
{
    public class ParkEventModel
    {
        public string ParkName { get; set; }
        public List<Event> Events { get; set; }
       //public int Size { get; set; }
        //public IEnumerable<SelectListItem> Events { get; set; }
        //public IEnumerable<Event> Events { get; set; }
        //public IEnumerable<Event> Names { get; set; }
      
    }
}
