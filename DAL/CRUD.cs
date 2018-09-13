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
                        string mobile = reader.GetString(3);
                        string position = reader.GetString(4);
                        int gender = reader.GetInt32(5);

                        Employees.Add(new Employee(id, idDepartment,name, mobile, position, gender));
                        

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
        public string CreateEmployee(object employee)
        {
            var employeeAdded = (Employee)employee;
            string sqlInsert = $"INSERT INTO Employees (IdDepartment, Name, MobilePhone, Position, Gender) VALUES ({employeeAdded.IdDepartment}, '{employeeAdded.Name}', '{employeeAdded.Mobile}', '{employeeAdded.Position}', {employeeAdded.Gender})";
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
        public string EditDepartment(object department)
        {
            var departmentEdited = (Department)department;
            string sqlInsert = $"UPDATE Departments SET OverId={departmentEdited.OverId}, Name='{departmentEdited.Name}', Info='{departmentEdited.Info}' WHERE Id={departmentEdited.Id}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                int number = command.ExecuteNonQuery();
                return ($"Изменено департаментов: {number}");

            }
        }
        public string DeleteDepartment(object department)
        {
            var departmentDeleted = (int)department;
            string sqlInsert = $"DELETE FROM Departments WHERE Id={departmentDeleted} OR OverId={departmentDeleted}";
            string sqlInsert1 = $"DELETE FROM Employees WHERE IdDepartment={departmentDeleted}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                SqlCommand command1 = new SqlCommand(sqlInsert1, connection);
                int number = command.ExecuteNonQuery();
                int number1 = command1.ExecuteNonQuery();
                return ($"Удалено департаментов: {number} /br Удалено работников: {number1}");

            }
            
        }

        public string EditEmployee(object Employees)
        {
            var EmployeesEdited = (Employee)Employees;
            string sqlInsert = $"UPDATE Employees SET IdDepartment={EmployeesEdited.IdDepartment}, Name='{EmployeesEdited.Name}', MobilePhone='{EmployeesEdited.Mobile}', Position='{EmployeesEdited.Position}', Gender={EmployeesEdited.Gender} WHERE Id={EmployeesEdited.Id}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                int number = command.ExecuteNonQuery();
                return ($"Изменено работников: {number}");

            }
        }
        public string DeleteEmployee(int Employees)
        {
            int EmployeesDeleted = Employees;
            string sqlInsert = $"DELETE FROM Employees WHERE Id={EmployeesDeleted}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlInsert, connection);
                int number = command.ExecuteNonQuery();
                return ($"Удалено работников: {number}");

            }

        }
    }
}
