using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class CRUD
    {
        private string connectionString = @"Data Source=pc\sqlexpress;Initial Catalog=DepartmentsAndEmployees;Integrated Security=True";
        public List<Employee> ReadEmployees()
        {
            var Employees = new List<Employee>();
            string sqlExpression = "SELECT * FROM Employees";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {


                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        int idDepartment = reader.GetInt32(1);
                        string name = reader.GetString(2);
                        DateTime date = reader.GetDateTime(3);
                        string mobile = reader.GetString(4);
                        string position = reader.GetString(5);
                        int gender = reader.GetInt32(6);

                        Employees.Add(new Employee(id, idDepartment,name, date, mobile, position, gender));
                        

                    }
                    reader.Close();
                    return (Employees);
                }
                else
                {
                    return (Employees);
                }
            }
        }
        public List<Department> ReadDepartments()
        {
            var Departments = new List<Department>();
            string sqlExpression = "SELECT * FROM Departments";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {


                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = reader.GetInt32(0);
                        int overId = reader.GetInt32(1);
                        string name = reader.GetString(2);
                        string info = reader.GetString(3);
                        
                        Departments.Add(new Department(id, overId, info, name));


                    }
                    reader.Close();
                    return (Departments);
                }
                else
                {
                    return (Departments);
                }
            }
        }
        public string CreateEmloyee(object employee)
        {
            var employeeAdded = (Employee)employee;
            string sqlInsert = $"INSERT INTO Employees (IdDepartment, Name, Birthday, MobilePhone, Position, Gender) VALUES ({employeeAdded.IdDepartment}, '{employeeAdded.Name}', {employeeAdded.Date}, '{employeeAdded.Mobile}', '{employeeAdded.Position}', {employeeAdded.Gender})";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                int number = command.ExecuteNonQuery();
                return ($"Добавлено работников: {number}");

            }
        }
        public string CreateDepartment(object department)
        {
            var departmentAdded = (Department)department;
            string sqlInsert = $"INSERT INTO Departments (OverId, Name, Info) VALUES ({departmentAdded.OverId}, '{departmentAdded.Name}', '{departmentAdded.Info}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                int number = command.ExecuteNonQuery();
                return ($"Добавлено департаментов: {number}");

            }
        }
    }
}
