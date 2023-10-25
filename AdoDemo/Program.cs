using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = ConfigurationManager.AppSettings["connectionString"];
/*            Console.WriteLine(path);
*/
            //create a connection object
            SqlConnection conn = new SqlConnection(path);

            //open connection
            conn.Open();

            //tasks
            Console.WriteLine("State: "+conn.State);
            Console.WriteLine("Server Name: " + conn.DataSource);
            Console.WriteLine("Database Name: " + conn.Database);
            Console.WriteLine("TimeOut: " + conn.ConnectionTimeout);

            //close connection
            conn.Close();
            Console.WriteLine("State: " + conn.State);
        }
    }
}
