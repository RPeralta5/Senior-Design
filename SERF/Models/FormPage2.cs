using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SERF.Models
{
    [Table("EventInformation")]
    public class FormPage2
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EventInformationId { get; set; }
        public String EventName { get; set; }
        public String NamedInsuredRole { get; set; }

        public String EventPrivacy { get; set; }

        public String AdmissionCharge { get; set; }

        public String Donation { get; set; }

        public String Seating { get; set; }

        public String Security { get; set; }

        public String FirstAide { get; set; }

        public String Ada { get; set; }

        public String Advertisement { get; set; }

        public String Alcohol { get; set; }

        public String RecreationalActivity { get; set; }

        public String Music { get; set; }

        public String Activities { get; set; }

        public List<EventDate> EventDates { get; set; }
    }
}