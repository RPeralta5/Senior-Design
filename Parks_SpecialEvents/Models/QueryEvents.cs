﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Parks_SpecialEvents.Models
{
    public class QueryEvents
    {
        private readonly IConfiguration _config;

        public QueryEvents(IConfiguration config)
        {
            _config = config;
        }

        private string PARK_DB_CONNECTION
        {
            get { return _config.GetValue<string>("ConnectionString:default"); }
        }

        public QueryEvents()
        {
        }

        public List<Event> GetAllEvents(string parkID)
        {
            List<Event> events = new List<Event>();
            
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT DISTINCT EventID FROM Event;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // get all events
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Event e = new Event();
                        e.EventID = (int)reader[0];
                        e.ParkID = parkID;
                        e.Flag = false; // flag every event

                        events.Add(e);
                    }
                }

                // close connection
                sqlConnection.Close();
            }

            return events;
        }

        public void updateEvents(AzureMasterPark azureMasterPark)
        {
            string parkID = azureMasterPark.AzurePark.ParkID;
            string query = "";
            List<Event> allEvents = GetAllEvents(parkID);
            
            List<Event> heldByPark = azureMasterPark.Events.Events;

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                sqlConnection.Open();
                foreach (Event e in allEvents)
                {
                    int count = 0;
                    foreach(Event x in heldByPark)
                    {
                        count++;
                        if (count == heldByPark.Count)
                        {
                            // not held by park                   
                    
                            query = "UPDATE Event " + 
                                        $" SET Flag = {0}" +
                                        $" WHERE EventID = {e.EventID} AND ParkID = '{parkID}';";
                            
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                        }
                        
                        if (e.EventID == x.EventID)
                        {
                            query = "UPDATE Event " +
                                        $" SET Flag = {1}" +
                                        $" WHERE EventID = {e.EventID} AND ParkID = '{parkID}';";
                            
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            break;
                        }
                    }

                }
                sqlConnection.Close();
            }

        }

        public void addEvents(List<string> events, string parkID)
        {
            QueryEventInfo queryEventInfo = new QueryEventInfo(_config);
            List<string> allEvents = queryEventInfo.getDistinctEvents();

            // query
            string query = "INSERT INTO Event(EventID,ParkID,Flag)";

            int counter = 0;
            foreach (string e in allEvents)
            {
                counter++;
                if (events.Contains(e))
                {
                 
                    int eventID = queryEventInfo.getEventID(e);
                    
                    if(counter == 1)
                    {
                        query += $" VALUES ({eventID},'{parkID}', 1),";
                    } else
                    {
                        if(counter == allEvents.Count)
                        {
                            query += $" ({eventID},'{parkID}', 1);";
                        } else
                        {
                            query += $" ({eventID},'{parkID}', 1),";
                        }

                    }
                    
                } else
                {
                    int eventID = queryEventInfo.getEventID(e);

                    if(counter == 1)
                    {
                        query += $" VALUES ({eventID},'{parkID}', 0),";
                    } else
                    {
                        if (counter == allEvents.Count)
                        {
                            query += $" ({eventID},'{parkID}', 0);";
                        }
                        else
                        {
                            query += $" ({eventID},'{parkID}', 0),";
                        }
                    }
                }
            }
            
            using (SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // add to database
                sqlCommand.ExecuteNonQuery(); // used to be ExecuteReader()

                // close sql connection
                sqlConnection.Close();
            }

        }

        public void addEvent(int eventID, string parkID)
        {
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "INSERT INTO Event(EventID,ParkID)"
                   + $" VALUES ({eventID},'{parkID}');";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open sql connection
                sqlConnection.Open();

                // add to database
                sqlCommand.ExecuteNonQuery(); // used to be executeReader()

                // close sql connection
                sqlConnection.Close();
            }
        }
    }
}
