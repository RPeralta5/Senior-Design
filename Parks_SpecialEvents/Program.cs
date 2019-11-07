using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Parks_SpecialEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CONNECTION STRING
            //String cString = "data source=.; database = Music; user id = sa; password = myPassw0rd;";
            //SqlConnection sqlConnection = new SqlConnection(cString);
            //Console.WriteLine("CONNECTION STRING: " + sqlConnection);

            //// SQL COMMAND
            //String command =
            //    "INSERT INTO Artists (ArtistName, ActiveFrom) VALUES" +
            //    " ('Kygo','1975-12-25'), ('Avicii', '2017-12-12');";

            //SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            //// OPEN THE CONNECTION

            //sqlConnection.Open();
            //Console.WriteLine("SQL CONNECTION IS OPEN");
            //// EXECUTE SQL COMMAND

            //sqlCommand.ExecuteReader();

            //// CLOSE CONNECTION

            //sqlConnection.Close();
            //Console.WriteLine("SQL CONNECTION IS CLOSED");

            //Console.WriteLine(sqlConnection);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
