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
                Console.WriteLine("1) Create Database\n");
                int result = (int)Convert.ToInt64(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        Payroll.CreateDatabase();
                        break;
                }
            }
        }
    }
}