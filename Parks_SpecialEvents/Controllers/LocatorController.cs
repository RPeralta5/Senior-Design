﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parks_SpecialEvents.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

/* 
 * Author(s): Ryan Peralta
 * Last Updated: 2/16/2020
 * Removed unused code and wrote comments.
*/

namespace Parks_SpecialEvents.Controllers
{
    public class LocatorController : Controller
    {
        // Database connection string
        private readonly IConfiguration _config;

        public LocatorController(IConfiguration config)
        {
            _config = config;
        }

        private string PARKSCONNECTIONSTRING
        {
            get { return _config.GetValue<string>("ConnectionString:default"); }
        }

        // Model to hold list of parks
        ParkDB parkInfo = new ParkDB();
        
        // List of Events(names) to be inspected in the Index.cshtml file
        List<Event> eventStorage = new List<Event>();

        // List of events
        List<EventType> eventTypeStorage = new List<EventType>();

        //Database Queries
        const string QUERY_FOR_PARK_INFO = "SELECT DISTINCT Parks.ParkID, ParkName, Lat, Lng, Image, Event_Name, Flag" +
                  " FROM Event" +
                  " INNER JOIN Event_Info ON" +
                  " Event.EventID = Event_Info.EventID" +
                  " INNER JOIN Parks ON" +
                  " Parks.ParkID = Event.ParkID" +
                  " Where Flag = 1";
        const string EVENTS = "  SELECT DISTINCT Event_Name, Href FROM Event_Info";
        const string EVENT_TYPES = "Select distinct Event_Type from Event_Info";
        const string SUB_EVENT = " Select Distinct Event_Name, Href From Event_Info";


        /*
         * Function that gathers all park information from the database and stores it into a model. 
         */
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

                        // Information we are storing:
                        // Parks.ParkID, ParkName, Lat, Lng, Image, Event, Flag
                        parkInfo.AddPark(new Park((string)reader[0], (string)reader[1], "",
                        (double)reader[2], (double)reader[3], (string)reader[4],
                        (string)reader[5], (bool)reader[6]));
                    }
                }
                // CLOSE CONNECTION
                sqlConnnection.Close();
            }
            return parkInfo;
        }

        /*
         *  Function that gathers all event names and hrefs
         */
        private List<Event> QueryEvents(string query)
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
                        // Information we are storing:
                        // Event Name and Event Href
                        eventStorage.Add(new Event((string)reader[0],(string)reader[1], true));
                    }
                }

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }
            return eventStorage;
        }

        /*
         * Function that creates a list of event types that contain a list of events that fall ito its category.
         */
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
                        
                        eventTypeStorage.Add(new EventType((string)reader[0]));
                    }
                }

                // CLOSE CONNECTION
                sqlConnnection.Close();
            }
            return eventTypeStorage;
        }



        /*
         * Function that looks through the events in the database and retrieves additional information for each event.
         * 
         * In this function, go through that list and add a list of events to each corresponding EventType Object
         * int index is the index of the item in the list we are currently on! So we can add events to that coresponding list!
         */
        private void QuerySubEvents(string query, int index)
        {
            using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {
    
                string command = query;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);
                sqlConnnection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       
                        //Adding an event to the list for each sub type
                        eventTypeStorage[index].AddToList(new Event((string)reader[0], (string)reader[1], true));
                        
                    }
                }
                sqlConnnection.Close();
            }
        }

        private void GetDistinctParks(string eventTypeName, int index)
        {
            using (SqlConnection sqlConnnection = new SqlConnection(PARKSCONNECTIONSTRING))
            {

                string query = "Select distinct Event.ParkID, ParkName, Image " +
                "from event_info " +
                "inner join event ON " +
                "Event_info.EventID = Event.EventID " +
                "inner join Parks ON " +
                "Parks.ParkID = Event.ParkID " +
                "where Event_Type = '" + eventTypeName + "' AND Flag = 1;";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnnection);
                sqlConnnection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        //Adding an event to the list for each sub type
                        eventTypeStorage[index].AddParkThumbnail(new ParkThumbnail((string)reader[0], (string)reader[1], (string)reader[2]));

                    }
                }
                sqlConnnection.Close();
            }
        }



        /*
         * Function that is called when Index.cshtml is ran.
         * Runs other functions created in this file.
         */
        public IActionResult Index()
        {
            // STORE IN VIEWBAG
            ViewBag.storePermitables = QueryEvents(EVENTS);
            ViewBag.storeParks = QueryParks(QUERY_FOR_PARK_INFO);
            List<EventType> eventTypeList = QueryEventTypes(EVENT_TYPES);


            //Populate eventTypeList with information for each event
            for (int i = 0; i < eventTypeList.Count; i++)
            {
                string query = "SELECT Event_Name, Href from event_info where event_type = '" + eventTypeList[i].Name + "'";
                QuerySubEvents(query, i);
                GetDistinctParks(eventTypeList[i].Name, i);
            }
            ViewBag.eventInfo = eventTypeList;
            return View();
        }

    }
}
