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
        public static SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=Payroll_Service; integrated security=true");
        public bool Display()
        {
            try
            {
                using (con)
                {
                    Employee model = new Employee();
                    string query = "select * from Employee_Payroll";
                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader sqldatareader = command.ExecuteReader();
                    if (sqldatareader.HasRows)
                    {
                        Console.WriteLine("----Data----");
                        while (sqldatareader.Read())
                        {
                            model.Id = Convert.ToInt16(sqldatareader["Id"]);
                            model.Name = Convert.ToString(sqldatareader["Name"]);
                            model.Salary = Convert.ToInt64(sqldatareader["Salary"]);
                            model.Start_Date = Convert.ToDateTime(sqldatareader["Start_Date"]);
                            model.Gender = Convert.ToChar(sqldatareader["Gender"]);
                            model.Phone_Number = (int)Convert.ToInt64(sqldatareader["Phone_Number"]);
                            model.Address = Convert.ToString(sqldatareader["Address"]);
                            model.Department = Convert.ToString(sqldatareader["Department"]);
                            model.Basic_Pay = Convert.ToInt64(sqldatareader["Basic_Pay"]);
                            model.Deductions = Convert.ToInt64(sqldatareader["Deductions"]);
                            model.Taxable_Pay = Convert.ToInt64(sqldatareader["Taxable_Pay"]);
                            model.Income_Tax = Convert.ToInt64(sqldatareader["Income_Tax"]);
                            model.Net_Pay = Convert.ToInt64(sqldatareader["Net_Pay"]);
                            Console.WriteLine("Id: {0}\nName: {1}\nSalary: {2}\nStart_Date: {3}\nGender: {4}\nPhone_Number: {5}\nAddress: {6}\nDepartment: {7}\nBasic_Pay: {8}\nDeductions: {9}\nTaxable_Pay: {10}\nIncome_Tax: {11}\nNet_Pay: {12}\n", model.Id, model.Name, model.Salary, model.Start_Date, model.Gender, model.Phone_Number, model.Address, model.Department, model.Basic_Pay, model.Deductions, model.Taxable_Pay, model.Income_Tax, model.Net_Pay);
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
            return false;
        }
    }

