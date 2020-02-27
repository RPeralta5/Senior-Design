using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Parks_SpecialEvents.Models
{
    public class QueryEvents
    {
        const string PARK_DB_CONNECTION = @"data source=.; database= PARKS_TEST; user id = sa; password = myPassw0rd";

        public QueryEvents()
        {
        }

        public void addEvents(List<string> events, string parkID)
        {
            QueryEventInfo queryEventInfo = new QueryEventInfo();
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
                    Console.WriteLine($"event: {e}");
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
            Console.WriteLine($"query: {query}");
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
