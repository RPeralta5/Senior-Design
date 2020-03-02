using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SERF.Models
{
    [Table("EventDate")]
    public class EventDate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EventDateId { get; set; }

        public int EventInformationId { get; set; }
        public String Date { get; set; }

        public String BegTime { get; set; }

        public String EndTime { get; set; }

        public String AttendenceCount { get; set; }

        public String AlcoholBeverages { get; set; }

        public String EventDetails { get; set; }
    }
}