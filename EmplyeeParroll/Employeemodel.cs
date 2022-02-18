using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeePayroll
{
    class Employeemodel
    {
        public int EmployeeID { get; set; } //Decalring the values
        public string EmployeeName { get; set; }
        public string  StartDate { get; set; }
        public double BasicPay { get; set; }
        public string Gender { get; set; }
        public double PhoneNumber { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public double Taxablepay { get; set; }
    }
}
