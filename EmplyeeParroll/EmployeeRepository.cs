using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeePayroll
{/// <summary>
/// SQL DataBase
/// </summary>
    internal class EmployeeRepository
    {
        /// <summary>
        /// Reading the data from the SQL datbase
        /// </summary>
        public static string ConnectingString = "Data Source=DESKTOP-I8QS7VH\\SQLEXPRESS;Initial Catalog=EmployeepayrollInfo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection connection = new SqlConnection(ConnectingString);

        public static void GetAllEmployee() //this method is used for the reading the data
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectingString);
                connection.Open(); //we open the connection
                Employeemodel model = new Employeemodel();
                string query = "select * from Employee_payrollinfo";
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //model.EmployeeID = Convert.ToInt32(reader["Id"] == DBNull.Value ? default : reader["Id"]);
                        //model.EmployeeName = reader["Name"] == DBNull.Value ? default : reader["Name"].ToString();
                        //model.StartDate = Convert.ToString((DateTime)(reader["StartDate"] == DBNull.Value ? default(DateTime) : reader["StartDate"]));
                        model.BasicPay = Convert.ToDouble(reader["Basepay"] == DBNull.Value ? default : reader["Basepay"]);
                        model.Gender = reader["Gender"] == DBNull.Value ? default : reader["Gender"].ToString();
                       // model.PhoneNumber = Convert.ToDouble(reader["Phnum"] == DBNull.Value ? default : reader["Phnum"]);
                        model.Department = reader["Department"] == DBNull.Value ? default : reader["Department"].ToString();
                        //model.Address = reader["Address"] == DBNull.Value ? default : reader["Address"].ToString();
                        model.Taxablepay = Convert.ToDouble(reader["Taxable"] == DBNull.Value ? default : reader["Taxable"]);
                        Console.WriteLine("{0},{1},{2},{3}",model.BasicPay,model.Gender,model.Department,model.Taxablepay);
                    }
                }
                else
                {
                    Console.WriteLine("No rows is present");
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AddEmployee(Employeemodel model)
        {
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("dbo.spAddEmployee", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", model.EmployeeName);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@BasePay", model.BasicPay);
                    command.Parameters.AddWithValue("Department", model.Department);
                    command.Parameters.AddWithValue("Gender",model.Gender);
                    command.Parameters.AddWithValue("StartDate", model.StartDate);
                    connection.Open();
                    var result=command.ExecuteNonQuery();
                    if(result != 0)
                    {
                        Console.WriteLine("Succefully Inserted a Record");
                    }
                    else
                    {
                        Console.WriteLine("Unsuccessfull");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }
        }
        public static void UpdatePerson(Employeemodel model)
        {
            try
            {
                using (connection)
                {
                    Employeemodel displaymodel=new Employeemodel();
                    SqlCommand command = new SqlCommand("dbo.spUpdatePerson", connection);
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id",model.EmployeeID);
                    command.Parameters.AddWithValue("BasePay", model.BasicPay);
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        Console.WriteLine("Succefully Inserted a Record");
                    }
                    else
                    {
                        Console.WriteLine("Unsuccessfull");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }
        }
    }
}
