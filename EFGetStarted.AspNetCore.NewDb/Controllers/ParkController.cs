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
        static int ParkID = 1;
        static string address = "Elysian Park, Los Angeles, CA";
        static double lat = 34.0838;
        static double lng = -118.2366;
        static string image = "~/images/gerson-repreza-tNQ2tmQiC6g-unsplash.jpg";
        static string permit = "Alcohol";
        Park park = new Park(ParkID, address, lat, lng, image, permit);
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.store = park;
            return View("Index");
        }

        public async Task<IActionResult> ParkAsync(string address)
        {
            Console.WriteLine("Clicked on Image: INSIDE PARK ");
            Console.WriteLine($"Parked Clicked on: {address}");
            // IF ADDRESS IS NULL REDIRECT TO INDEX PAGE
            if (address == null || address == "")
            {
                Console.WriteLine("ADDRESS IS NULL REDIRECTING TO INDEX");
                return RedirectToAction("Index");
            }

            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyDbog5Hmj_SwDRN3lQWLa5Xw8OcMyzSFfw" };

            IEnumerable<Address> addresses = await geocoder.GeocodeAsync(address);

            try
            {
                Address a = addresses.First();

                int id = 1;
                string fAddress = a.FormattedAddress;
                double lat = a.Coordinates.Latitude;
                double lng = a.Coordinates.Longitude;
                string image = "~/images/gerson-repreza-tNQ2tmQiC6g-unsplash.jpg";
                string permitables = "Alcohol";
                Park p = new Park(id, fAddress, lat, lng, image, permitables);
                ViewBag.store = p;
                Console.WriteLine("SENDING VIEW TO PARK");
                return View("Park");
            } catch(Exception e)
            {
                Console.WriteLine(e);
                // REDIRECT TO ACTION METHOD IF FETCH FAILED
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> RouteAsync(string address)
        {
            Console.WriteLine("INSIDE ROUTE METHOD");
            Console.WriteLine($"Park Address {address}");


            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyDbog5Hmj_SwDRN3lQWLa5Xw8OcMyzSFfw" };

            IEnumerable<Address> addresses = await geocoder.GeocodeAsync(address);

            try
            {
                Address a = addresses.First();

                int id = 1;
                string fAddress = a.FormattedAddress;
                double lat = a.Coordinates.Latitude;
                double lng = a.Coordinates.Longitude;
                string image = "~/images/gerson-repreza-tNQ2tmQiC6g-unsplash.jpg";
                string permitables = "Alcohol";
                Park p = new Park(id, fAddress, lat, lng, image, permitables);
                ViewBag.park = p;
                Console.WriteLine("SENDING VIEW TO ROUTE");
                return View("Route");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // REDIRECT TO ACTION METHOD IF FETCH FAILED
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> SearchAsync(string address)
        {
            // IF ADDRESS IS NULL REDIRECT TO INDEX PAGE
            if (address == null || address == "")
            {
                return RedirectToAction("Index");
            }

            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyDbog5Hmj_SwDRN3lQWLa5Xw8OcMyzSFfw" };

            IEnumerable<Address> addresses = await geocoder.GeocodeAsync(address);

            //  TRY TO FETCH THE PARK
            try
            {
                Address a = addresses.First();

                int id = 1;
                string pA = a.FormattedAddress;
                double lat = a.Coordinates.Latitude;
                double lng = a.Coordinates.Longitude;
                string image = "~/images/gerson-repreza-tNQ2tmQiC6g-unsplash.jpg";
                string permitalbes = "Alcohol";

                Console.WriteLine($"Lat: {lat}");
                Console.WriteLine($"Lng: {lng}");
                Park p = new Park(id, pA, lat, lng, image, permitalbes);

                ViewBag.store = p;
                return View("Search");
            } catch(Exception e)
            {
                Console.WriteLine(e);
                // REDIRECT TO ACTION METHOD IF FETCH FAILED
                return RedirectToAction("Index");
            }
            
        }
    }
}
