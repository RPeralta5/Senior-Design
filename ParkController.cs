using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFGetStarted.AspNetCore.NewDb.Models;
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

        Park park = new Park(address, name, lat, lng);
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.store = park;
            return View("Index");
        }

        public async Task<IActionResult> SearchAsync(string address)
        {
         
            if (address == null || address == "")
            {
                return RedirectToAction("Index");
            }

            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "YOUR GOOGLE API KEY" };

            IEnumerable<Address> addresses = await geocoder.GeocodeAsync(address);

            //  TRY TO FETCH THE PARK
            try
            {
                Address a = addresses.First();

                string pA = a.FormattedAddress;
                string name = a.FormattedAddress;
                double lat = a.Coordinates.Latitude;
                double lng = a.Coordinates.Longitude;

                Park p = new Park(pA, name, lat, lng);

                ViewBag.store = p;
                return View("Search");
            } catch(Exception e)
            {
                // REDIRECT TO ACTION METHOD IF FETCH FAILED
                return RedirectToAction("Index");
            }
            
        }
    }
}
