﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Parks_SpecialEvents.Models
{
    public class AzurePark
    {
        public string ParkID { get; set; }
        public string ParkName { get; set; }
        public string ParkLastName { get; set; }
        public string Address { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string FacilityPhone { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double GISAcres { get; set; }
        public double InventoryAcres { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public AzurePark()
        {
        }

        public bool FieldLeftEmpty()
        {
            Console.WriteLine(this.ParkName);
            Console.WriteLine(ParkName);
            Console.WriteLine(ParkName == null);
            // check basic info
            if (ParkName == null)
            {
                return true;
            }
            return false;
        }
    }
}
