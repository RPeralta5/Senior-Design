using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Parks_SpecialEvents.Models
{
    public class QueryEventInfo
    {
        private readonly IConfiguration _config;

        public QueryEventInfo(IConfiguration config)
        {
            _config = config;
        }

        private string PARK_DB_CONNECTION
        {
            get { return _config.GetValue<string>("ConnectionString:default"); }
        }

        public QueryEventInfo()
        {
        }

        public int getEventID(string eventName)
        {
            int eventID = -1;
            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT EventID FROM Event_Info" +
                    $" WHERE Event_Name = '{eventName}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // get eventID
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        eventID = (int) reader[0];
                    }
                }

                // close conenction
                sqlConnection.Close();
            }
            return eventID;
        }

        public List<string> getDistinctEvents()
        {
            List<string> events = new List<string>();

            using(SqlConnection sqlConnection = new SqlConnection(PARK_DB_CONNECTION))
            {
                // query
                string query = "SELECT Event_Name FROM Event_Info;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // open connection
                sqlConnection.Open();

                // read data
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        events.Add((string)reader[0]);
                    }
                }

                // close connection
                sqlConnection.Close();
            }

            return events;
        }
    }
}
