using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SERF.Models
{
    [Table("Event Location")]
    public class FormPage3
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EventLocationId { get; set; }
        public String FacilityName { get; set; }
        public String StreetName { get; set; }
        public String City { get; set; }
        public String OutdoorArea { get; set; }
        public String VendorList { get; set; }
        public String ExhibitorList { get; set; }


    }
}