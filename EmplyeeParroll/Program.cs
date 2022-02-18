using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeRepository.GetAllEmployee();
            Employeemodel model=new Employeemodel();
            model.EmployeeName ="Raja";
            model.Address = "Hyd";
            model.BasicPay = 500000;
            model.Department = "SE";
            model.Gender = "M";
            model.StartDate = "12-4-2019";
            EmployeeRepository.AddEmployee(model);

        }
    }
}
