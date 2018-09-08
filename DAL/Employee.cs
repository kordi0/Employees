using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        public Employee(int id, int idDepartment, string name, DateTime date, string mobile, string position, int gender)
        {
            Id = id;
            IdDepartment = idDepartment;
            Name = name;
            Date = date;
            Mobile = mobile;
            Position = position;
            Gender = gender;
        }

        public int Id { get; set; }
        public int IdDepartment { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Mobile { get; set; }
        public string Position { get; set; }
        public int Gender { get; set; }
    }
}
