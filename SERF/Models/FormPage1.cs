using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SERF.Models
{
    [Table("ApplicantInformation")]
    public class FormPage1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ApplicantInfoId { get; set; }
        public String InsurerRole { get; set; }
        public String NameInsured { get; set; }
        public String Dba { get; set; }
        public String MailingAddress { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zipcode { get; set; }
        public String ContactPerson { get; set; }
        public String Email { get; set; }
        public String HomeNumber { get; set; }
        public String BusinessNumber { get; set; }
        public String Fax { get; set; }
        public String Website { get; set; }

    }
}