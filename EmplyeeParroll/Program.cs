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
            //EmployeeRepository.SumOfNetplay(model);
            //EmployeeRepository.MaxValueOfBasedOnGender(model);
            //EmployeeRepository.MinValueOfBasedOnGender(model);
            EmployeeRepository.InsertValuesToTheTransactionQueries();
            model.EmployeeID = 2013323;
            model.ComapanyId = 2022;
            model.EmployeeName ="Nari";
            model.PhoneNumber = 894883894;
            model.StartDate = "3-4-2019";
            model.DepartId = 4;
            model.Department = "SET";
        }
    }
}
