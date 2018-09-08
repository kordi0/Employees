using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employers;
using DAL;
using BL;

namespace Employers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            var f = new frmAddDepartment();
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            treeDepartments.Nodes.Add("Все отделения");
            var DepartmentsLoad = new Logic();
            List<Department> departments = new List<Department>();
            departments = DepartmentsLoad.GetDepartments();
            var longestNode = departments.Max(x => x.OverId);
            int i = 0;
            while (i < 10)
            {
                foreach (var j in departments)
                {
                    if (j.OverId == i)
                    {
                        treeDepartments.Nodes[i].Nodes.Add(j.Name);
                    }
                }
                i++;
            }
            
        }
    }
}
