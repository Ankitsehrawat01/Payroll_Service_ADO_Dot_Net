using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODOTNETEmployeePayroll
{
    public class Payroll
    {
        public static void CreateDatabase()
        {
            SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=master; integrated security=true");
            try
            {
                //writing sql query
                string query = "create database Payroll_Service";
                SqlCommand cm = new SqlCommand(query, con);
                //Opening Connection
                con.Open();
                //Executing the SQL query
                cm.ExecuteNonQuery();
                //Displaying a message
                Console.WriteLine("Database Created Successfully");
                Console.WriteLine("--------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something Went Wrong " + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
