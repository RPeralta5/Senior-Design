using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parks_SpecialEvents.Models;
//using Parks_SpecialEvents.Models;
using System.Data.SqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parks_SpecialEvents.Controllers
{
    public class LocatorController : Controller
    {
        // STORE QUESTIONS IN A DATABASE
        QuestionDB questionDB = new QuestionDB();

        // PARKS CONNECTION STRING
        const string PARKSCONNECTIONSTRING = @"Data Source=LAPTOP-M67PUJ2M;Initial Catalog=parks_faqDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // STORE PARKS IN A DATABASE
        ParkDB parkDB = new ParkDB();

        // STORE PERMITABLES ONLY
        List<Event> permitableDB = new List<Event>();
        List<EventType> eventTypeStorage = new List<EventType>();

        // QUERY FOR ALL PERMIT PARKS
        //const string QUERY_FOR_ALL_PERMIT_PARKS = "SELECT DISTINCT Parks.ParkID, ParkName, Lat, Lng, Image, Event" +
        //        " FROM Parks, Events" +
        //        " WHERE Parks.ParkID = Events.ParkID;";
        const string QUERY_FOR_ALL_PERMIT_PARKS = "SELECT DISTINCT Parks.ParkID, ParkName, Lat, Lng, Image, Event_Name, Flag" +
                  " FROM Event" +
                  " INNER JOIN Event_Info ON" +
                  " Event.EventID = Event_Info.EventID" +
                  " INNER JOIN Parks ON" +
                  " Parks.ParkID = Event.ParkID" +
                  " Where Flag = 1";

       

        /*   PERMITABLES ARE THE BUTTONS AT THE VERY TOP WHICH SHOW YOU WHICH PARKS CAN DO
         *   CERTAIN THINGS
        */

        //const string PERMITABLES = "SELECT DISTINCT Event, Href FROM Events"; // used to end in ;
        const string EVENTS = "  SELECT DISTINCT Event_Name, Href FROM Event_Info";

        const string EVENT_TYPES = "Select distinct Event_Type from Event_Info";

        const string SUB_EVENT = " Select Distinct Event_Name, Href From Event_Info";


        private ParkDB QueryParks(string query)
        {
            // CONNECT TO PARKS DATABASE
            using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
                // COMMAND TO EXECUTE
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                // OPEN SQL CONNECTION
                sqlConnnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Parks.ParkID, ParkName, Lat, Lng, Image, Event, Flag
                        Console.WriteLine($"PARK: {(string)reader[1]} + , FLAG: {(bool)reader[6]}");
                        //string id, string parkName, string address, double lat, double lng, string image, string permitables
                        parkDB.AddPark(new Park((string)reader[0], (string)reader[1], "",
                        (double)reader[2], (double)reader[3], (string)reader[4],
                        (string)reader[5], (bool)reader[6]));
                    }
                }

                foreach (Park p in parkDB.parks)
                {
                    Console.WriteLine($"Permitables: {p.Event}");
                }
                Console.WriteLine($"SIZE OF PARK DATABASE: {parkDB.Size}");

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }
            return parkDB;
        }

        private List<Event> QueryPermitables(string query)
        {
            // CONNECT TO PARKS DATABASE
            using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
                // COMMAND TO EXECUTE
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                // OPEN SQL CONNECTION
                sqlConnnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Parks.ParkID, ParkName, Lat, Lng, Image, Event
                        //Console.WriteLine($"PermitID: {reader[0]} ParkID: {reader[1]}, Permitable: {reader[2]} Href: {reader[3]}");
                        permitableDB.Add(new Event((string)reader[0],
                            (string)reader[1], true));
                    }
                }

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }
            return permitableDB;
        }

        private List<EventType> QueryEventTypes(string query)
        {
            // CONNECT TO PARKS DATABASE
            using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
                // COMMAND TO EXECUTE
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                // OPEN SQL CONNECTION
                sqlConnnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Parks.ParkID, ParkName, Lat, Lng, Image, Event
                        //Console.WriteLine($"PermitID: {reader[0]} ParkID: {reader[1]}, Permitable: {reader[2]} Href: {reader[3]}");
                        eventTypeStorage.Add(new EventType((string)reader[0]));
                    }
                }

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }


               /*Debugging 1/24/2020 11:30Am
                * 
                * 1st connection looks to be working, just make another method that edits the list instead of opening another connection here!
                * in index do a for loop, and then call the method that adds the sub events to the event types!

            //In this second connection, I want to go through the list of event types and get a list of events for each type
            //Ex. for celebration, it contains a list of events that are categorized under celebration, weddings, quinceneras, etc.
            using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
                // COMMAND TO EXECUTE
                for (int i = 0; i < eventTypeStorage.Count; i++)
                {
                    string com = "SELECT Event_Name, Href from event_info where event_type = '" +eventTypeStorage[i] + "'";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                    // OPEN SQL CONNECTION
                    sqlConnnection.Open();

                    // READ DATA
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                         
                            //Adding an event to the list for each sub type
                            eventTypeStorage[i].AddToList(new Event((string)reader[0],
                            (string)reader[1], true));
                        }
                    }
                }

                

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }
            */


            return eventTypeStorage;
        }




        private void QuerySubEvents(string query, int index)
        {

            //The only thing that QueryEventTypes does is return a list of the event types
            //In this function, go through that list and add a list of events to each corresponding EventType Object

            //int index is the index of the item in the list we are currently on! So we can add events to that coresponding list!

            // CONNECT TO PARKS DATABASE
            using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
                // COMMAND TO EXECUTE
               // string com = "SELECT Event_Name, Href from event_info where event_type = '" + eventTypeStorage[i] + "'";


                //Query should be something like
                //Select Event, Href from events where event type = 'x'
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                // OPEN SQL CONNECTION
                sqlConnnection.Open();

                // READ DATA
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Parks.ParkID, ParkName, Lat, Lng, Image, Event
                        //Console.WriteLine($"PermitID: {reader[0]} ParkID: {reader[1]}, Permitable: {reader[2]} Href: {reader[3]}");
                       
                        //Adding an event to the list for each sub type
                        eventTypeStorage[index].AddToList(new Event((string)reader[0], (string)reader[1], true));
                        
                    }
                }

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }


            /*Debugging 1/24/2020 11:30Am
             * 
             * 1st connection looks to be working, just make another method that edits the list instead of opening another connection here!
             * in index do a for loop, and then call the method that adds the sub events to the event types!

         //In this second connection, I want to go through the list of event types and get a list of events for each type
         //Ex. for celebration, it contains a list of events that are categorized under celebration, weddings, quinceneras, etc.
         using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
         {
             // COMMAND TO EXECUTE
             for (int i = 0; i < eventTypeStorage.Count; i++)
             {
                 string com = "SELECT Event_Name, Href from event_info where event_type = '" +eventTypeStorage[i] + "'";

                 SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);

                 // OPEN SQL CONNECTION
                 sqlConnnection.Open();

                 // READ DATA
                 using (SqlDataReader reader = sqlCommand.ExecuteReader())
                 {
                     while (reader.Read())
                     {

                         //Adding an event to the list for each sub type
                         eventTypeStorage[i].AddToList(new Event((string)reader[0],
                         (string)reader[1], true));
                     }
                 }
             }



             // CLOSE CONNECTION
             sqlConnnection.Close();
         }
         */


        }



        //9:22 am 1/27/2019
        //Ran and nothing crashed, now edit the index and print out the eventTypeList info to make sure all the information is getting passed correctly.
        public IActionResult Index()
        {
            // STORE IN VIEWBAG
            //ViewBag.storePermitables = QueryPermitables(PERMITABLES);
            ViewBag.storePermitables = QueryPermitables(EVENTS);

            ViewBag.storeParks = QueryParks(QUERY_FOR_ALL_PERMIT_PARKS);


            //ViewBag.storeEventTypes 
            List<EventType> eventTypeList = QueryEventTypes(EVENT_TYPES);

            for (int i = 0; i < eventTypeList.Count; i++)
            {
                string query = "SELECT Event_Name, Href from event_info where event_type = '" + eventTypeList[i].Name + "'";
               // string q = ""
                QuerySubEvents(query, i);
            }

            ViewBag.eventInfo = eventTypeList;

            /*
             *List<EventType> sampleList = QueryEventTypes(EVENT_TYPES)
             * 
             *      Here the for loop is going to open another connection for each event type and add the events to each respective type!
             *      Need to implement QuerySubEvents!
             *      As of right now QueryEventTypes seem to be working, but implement adding the buttons on the index to make sure all of the types are getting through
             *      
             *      
             * for (int i = 0; i < sampleList.Count; i++)
                {
                        QuerySubEvents(sampleList[i]);
                }
             * 
             * 
             */






            return View();
        }

        
        
        private bool validate(string search)
        {
            List<string> keyWords = new List<string>();
            keyWords.Add("DELETE");
            keyWords.Add("UPDATE");
            keyWords.Add("SELECT");
            keyWords.Add("*");
            keyWords.Add("DROP");
            keyWords.Add("DROP TABLE");
            keyWords.Add(";");

            if (search == "" || search == null)
            {
                return false;
            }

            // IF KEYWORD IS FOUND RETURN FALSE
            foreach (string keyword in keyWords)
            {

                Console.WriteLine($"KEYWORDS: {keyword}");
                if (search.ToUpper().Contains(keyword))
                {
                    Console.WriteLine($"KEY WORD FOUND: {keyword}");
                    return false;
                }
            }

            return true;
        }
    }
}
