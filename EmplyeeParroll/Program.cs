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
            //model.EmployeeID =3;
            //model.EmployeeName = "Rasi";
            //EmployeeRepository.DeletePerson(model);
            //EmployeeRepository.InsertIntoTable();
            EmployeeRepository.SumOfNetplay(model);
            EmployeeRepository.MaxValueOfBasedOnGender(model);
            EmployeeRepository.MinValueOfBasedOnGender(model);

        }
    }
}
