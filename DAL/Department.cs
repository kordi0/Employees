using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Department
    {
        public Department(int id, int partentId, string info, string name)
        {
            Id = id;
            PartentId = partentId;
            Info = info;
            Name = name;
        }

        public int Id { get; set; }
        public int PartentId { get; set; }
        public string Info { get; set; }
        public string Name { get; set; }
        
    }
}
