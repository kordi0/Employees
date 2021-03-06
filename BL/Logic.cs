﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;



namespace BL
{
    public class Logic
    {
        
        public List<Department> GetDepartments()
        {
            var request = new CRUD();
            return request.ReadDepartments();
        }

        public List<Employee> GetEmployees()
        {
            var request = new CRUD();
            return request.ReadEmployees();
        }

        public string AddDepartments(Department department)
        {
            var create = new CRUD();
            var NewDepartment = department;
            var checkName = GetDepartments().Find(x => x.Name == NewDepartment.Name);
            if (checkName == null)
            {
                return create.CreateDepartment(NewDepartment);
            }
            else
            {
                return "Такое отделение уже есть";
            }
            
        }
        public string EditDepartment(Department o)
        {
            var O = o;
            var edit = new CRUD();
            var editedDepartment = GetDepartments().Find(x => x.Id == O.Id);
            editedDepartment = O;
            return edit.EditDepartment(editedDepartment).ToString();
        }

        public string DeleteDepartment(int SelectedId)
        {
            var delete = new CRUD();
            
            var deletedDepartment = GetDepartments().Find(x => x.Id == SelectedId);
            return delete.DeleteDepartment(deletedDepartment.Id).ToString();
        }

        public string AddEmployee(Employee employee)
        {
            var create = new CRUD();
            var NewEmployee = employee;
            var checkName = GetDepartments().Find(x => x.Name == NewEmployee.Name);
            if (checkName == null)
            {
                return create.CreateEmployee(NewEmployee);
            }
            else
            {
                return "Такой работник уже есть";
            }

        }

        public string EditEmployee(Employee Employee)
        {
            var edit = new CRUD();
            var employee = Employee;
            var EditedEmployee = GetEmployees().Find(x => x.Id == employee.Id);
            EditedEmployee = employee;
            return edit.EditEmployee(EditedEmployee).ToString();
        }

        public string DeleteEmployee(int SelectedId)
        {
            var delete = new CRUD();

            return delete.DeleteEmployee(SelectedId).ToString();
        }
    }
}
