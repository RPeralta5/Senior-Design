using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parks_SpecialEvents.Models;
using Geocoding;
using Geocoding.Google;
using System.Data.SqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parks_SpecialEvents.Controllers
{


    public class ParkController : Controller
    {
        static string ParkID = "EMPTY";
        static string name = "Elysian Park, Los Angeles, CA";
        static string address = "Elysian Park, Los Angeles, CA";
        static double lat = 34.0838;
        static double lng = -118.2366;
        static string image = "~/images/gerson-repreza-tNQ2tmQiC6g-unsplash.jpg";
        static string permit = "Alcohol";
        static bool flag = true;
        Park defaultPark = new Park(ParkID, name, address, lat, lng, image, permit, flag);

        // CONNECTION STRING FOR PARK DATABASE
        //const string PARK_DB_CONNECTION = @"Data Source=LAPTOP-M67PUJ2M;Initial Catalog=parks_faqDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        const string PARK_DB_CONNECTION = @"data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";


        // QUERY FOR PARK
        private Park QueryForPark(string id)
        {
            Park park = null;
            // CONNECT TO PARKS DATABASE
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string query = "SELECT ParkID, ParkName, Address, Lat, Lng, Image FROM Parks" + 
                        $" WHERE ParkID = '{id}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN SQL CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        park = new Park((string)reader[0], (string)reader[1], (string) reader[2], (double)reader[3],
                            (double)reader[4], (string) "", (string)reader[5], flag);
                        return park;
                    }
                }
            }
            return park;
        }

        // QUERY FOR A PARKS IMAGES
        //const string PARK_IMAGES = "SELECT * FROM ParkImages WHERE ParkID = ";
        
        private ParkImageDB QueryParkImagesForParkID(string id)
        {
            ParkImageDB parkImages = new ParkImageDB();
            Console.WriteLine("LOOKING FOR CAROUSEL PARK IMAGES");
            Console.WriteLine($"PARK ID: {id}");
            // CONNECT TO PARKS DATABASE
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // COMMAND TO EXECUTE
                string query = $"SELECT * FROM ParkImages WHERE ParkID = '{id}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        // ADD IMAGES FROM THAT PARK
                        Console.WriteLine($"IMAGE ID: {reader[0]}");
                        Console.WriteLine($"PARK ID: {reader[1]}");
                        Console.WriteLine($"IMAGE PATH: {reader[2]}");
                        parkImages.Add(new Image((int) reader[0], (string) reader[1],
                            (string) reader[2]));
                    }
                }
            }
            Console.WriteLine($"ALL IMAGES: {parkImages}");
            return parkImages;
        }

        private AmenityDB QueryAmenities(string parkID)
        {
            // AMENITIES DATA BASE
            AmenityDB amenityDB = new AmenityDB();

            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // QUERY
                string query =
                    $"SELECT AmenityID, ParkID, Amenity, Quantity, Image FROM Amenities, AmenityImages WHERE ParkID = '{parkID}' AND Amenities.ImageID = AmenityImages.ImageID";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"AMENITY: {reader[2]}");
                        amenityDB.addAmenity(new Amenity((int) reader[0], (string) reader[1],
                            (string) reader[2], (int) reader[3], (string) reader[4]));
                    }
                }
            }
            return amenityDB;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.store = defaultPark;
            return View("Index");
        }

        public IActionResult ParkAsync(string id)
        {
            Console.WriteLine($"PARK ID: {id}");

            // GET THE PARK
            Park park = QueryForPark(id);
            //Console.WriteLine($"PARK: {park.Address}");

            //IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "API_KEY" };

            //IEnumerable<Address> addresses = await geocoder.GeocodeAsync(park.Address); // used to have just address

            try
            {
               // Address a = addresses.First();

                //park.Address

                ViewBag.Images = QueryParkImagesForParkID(id);
                ViewBag.Amenities = QueryAmenities(id);
                ViewBag.store = park;
                return View("Park");
            } catch(Exception e)
            {
                Console.WriteLine("SOMETHING WENT WRONG");
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

                string id = "EMPTY";
                string name = "Elysian Park, Los Angeles, CA";
                string fAddress = a.FormattedAddress;
                double lat = a.Coordinates.Latitude;
                double lng = a.Coordinates.Longitude;
                string image = "~/images/gerson-repreza-tNQ2tmQiC6g-unsplash.jpg";
                string permitables = "Alcohol";
                Park p = new Park(id, name ,fAddress, lat, lng, image, permitables, flag);
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

           // return View("Route);
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

                string id = "EMPTY";
                string name = "Elysian Park, Los Angeles, CA";
                string pA = a.FormattedAddress;
                double lat = a.Coordinates.Latitude;
                double lng = a.Coordinates.Longitude;
                string image = "~/images/gerson-repreza-tNQ2tmQiC6g-unsplash.jpg";
                string phone = "Sample Phone";
                string permitalbes = "Alcohol";

                Console.WriteLine($"Lat: {lat}");
                Console.WriteLine($"Lng: {lng}");
                Park p = new Park(id, name, pA, lat, lng, image, permitalbes, flag);

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
