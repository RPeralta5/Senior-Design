using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SERF.Models
{
    public class FormPageContext : DbContext
    {
        public DbSet<FormPage1> PageOne { get; set; }
        public DbSet<FormPage2> PageTwo { get; set; }
        public DbSet<EventDate> EventDates { get; set; }
        public DbSet<FormPage3> PageThree { get; set; }
    }
}