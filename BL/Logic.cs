using System;
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
        public string AddDepartments(object department)
        {
            var request = new CRUD();
            var NewDepartment = (Department)department;
            return request.CreateDepartment(NewDepartment);
        }
    }
}
