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
            using (SqlConnection conn = new SqlConnection(path))
            {
                //open connection
                conn.Open();

                //tasks
                /*Console.WriteLine("State: " + conn.State);
                Console.WriteLine("Server Name: " + conn.DataSource);
                Console.WriteLine("Database Name: " + conn.Database);
                Console.WriteLine("TimeOut: " + conn.ConnectionTimeout);*/

                Console.WriteLine("Enter empno: ");
                string empno = Console.ReadLine();

                var query = "SELECT ENAME FROM EMP WHERE EMPNO=" + empno;

                //command object --> query, db details

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine("EMPLOYEE Name is:"+ dr["ename"]);
                }
            }// conn object is auto disposed
        }
    }
}
