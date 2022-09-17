using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODOTNETEmployeePayroll
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public DateTime Start_Date { get; set; }
        public char Gender { get; set; }
        public int Phone_Number { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public long Basic_Pay { get; set; }
        public long Deductions { get; set; }
        public long Taxable_Pay { get; set; }
        public long Income_Tax { get; set; }
        public long Net_Pay { get; set; }
    }
}
