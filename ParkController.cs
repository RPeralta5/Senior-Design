using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFGetStarted.AspNetCore.NewDb.Models;

/*
    USE THESE TWO
    YOU MUST ADD THEM TO YOUR DEPENDECIES FIRST TO USE THEM

        dotnet add package Geocoding.Core
    
        dotnet add package Geocoding.Google
*/
using Geocoding;
using Geocoding.Google;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
    public class ParkController : Controller
    {
        static string address = "Elysian Park, Los Angeles, CA";
        static string name = "Elysian Park";
        static double lat = 34.0838;
        static double lng = -118.2366;

        // DEFUALT PARK
        Park park = new Park(address, name, lat, lng);
        // GET: /<controller>/
        public IActionResult Index()
        {
            // Loads the default Park
            ViewBag.store = park;
            return View("Index");
        }

        public async Task<IActionResult> SearchAsync(string address)
        {
         
            if (address == null || address == "")
            {
                // REDIRECT TO INDEX METHOD IF NOTHING IS SEARCHED
                return RedirectToAction("Index");
            }

            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "INSERT YOUR APIKEY HERE" };

            // AN ENUMERABLE BECAUSE IT GEOCODER.GEOCODERASYNC RETURNS MULTIPLE ADDRESSES
            IEnumerable<Address> addresses = await geocoder.GeocodeAsync(address);
 
            Address a = addresses.First();
            string pA = a.FormattedAddress;
            string name = a.FormattedAddress;
            double lat = a.Coordinates.Latitude;
            double lng = a.Coordinates.Longitude;

            // CREATE A PARK INSTANCE
            Park p = new Park(pA, name, lat, lng);
            
            // STORE THAT INSTANCE OF PARK IN A VIEWBAG
            ViewBag.store = p;
            return View("Search");
        }
    }
}
