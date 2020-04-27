using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parks_SpecialEvents.Models;
using Geocoding;
using Geocoding.Google;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

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
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IConfiguration _config;

        public ParkController(IHostingEnvironment e ,IConfiguration config)
        {
            hostingEnvironment = e;
            _config = config;
        }

        private string PARK_DB_CONNECTION
        {
            get { return _config.GetValue<string>("ConnectionString:default"); }
        }

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
                        parkImages.Add(new Image((int) reader[0], (string) reader[1],
                            (string) reader[2]));
                    }
                }
            }

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
                        amenityDB.addAmenity(new Amenity((int) reader[0], (string) reader[1],
                            (string) reader[2], (int) reader[3], (string) reader[4]));
                    }
                }
            }
            return amenityDB;
        }


        public List<RegisteredEvent> QueryRegisteredEvents(string parkID)
        {
            List<RegisteredEvent> rEvents = new List<RegisteredEvent>();
           
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // QUERY
                string query =
                    $"Select ParkID, EventName, StartTime, EndTime, StartDate, EndDate from RegisteredEvents WHERE ParkID = '{parkID}'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // OPEN CONNECTION
                sqlConnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rEvents.Add(new RegisteredEvent((string)reader[0], (string)reader[1],
                            (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5]));
                    }
                }
            }
            return rEvents;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.store = defaultPark;
            return View("Index");
        }

        public IActionResult ParkAsync(string id)
        {

            // GET THE PARK
            AzureMasterPark masterPark = new AzureMasterPark();

            // basic park info
            QueryParks queryParks = new QueryParks(hostingEnvironment ,_config);
            masterPark.AzurePark = queryParks.getParkInfo(id);

            // park images
            QueryParkImages queryParkImages = new QueryParkImages(hostingEnvironment,_config);
            masterPark.AzureParkImages.ImagesPaths = queryParkImages.getImagesPath(id);

            // amenities
            QueryAmenities queryAmenities = new QueryAmenities(_config);
            masterPark.Amenitys = queryAmenities.GetAmenityImagesForParkID(id);

            //registered events
            masterPark.RegisteredEvents = QueryRegisteredEvents(id);

            ViewData["api_key"] = _config.GetValue<string>("GoogleAPIKey:jose");

            return View("Park", masterPark);
        }

        public async Task<IActionResult> RouteAsync(string address)
        {
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

            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = _config.GetValue<string>("GoogleAPIKey:jose") };

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
                //string phone = "Sample Phone";
                string permitalbes = "Alcohol";

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
