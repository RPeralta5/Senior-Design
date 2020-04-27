using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parks_SpecialEvents.Models
{
    public class RegisteredEvent
    {
        public string ParkID { get; set; }
        public string EventName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public RegisteredEvent(string id, string eName, string sTime, string eTime, string sDate, string eDate)
        {
            this.ParkID = id;
            this.EventName = eName;
            this.StartTime = sTime;
            this.EndTime = eTime;
            this.StartDate = sDate;
            this.EndDate = eDate;
        }





    }
}
