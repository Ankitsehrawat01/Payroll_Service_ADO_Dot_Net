namespace ADODOTNETEmployeePayroll
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Welcome to Customer Database");
                Console.WriteLine("1) Create Database\n" +
                                  "2) Retrive data from Database\n");
                int result = (int)Convert.ToInt64(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        Payroll.CreateDatabase();
                        break;
                    case 2:
                        Payroll payrollobj = new Payroll();
                        payrollobj.Display();
                        break;
                }
            }
        }
    }
}