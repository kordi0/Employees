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
        public void MakeNode(int parentId, int parentNode, string name)
        {
            if (parentId == parentNode)
            {
                treeDepartments.Nodes[1].Nodes.Add(new TreeNode(name));
            }
            else
            {
                MakeNode(parentId, parentNode + 1, name);
            }
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
            List<Department> SortedList = departments.OrderBy(x => x.Id).ToList();
            List<Department> ChildDepartments = new List<Department>();
            foreach (var i in SortedList)
            {
                if (i.OverId == 0)
                {
                    treeDepartments.Nodes[0].Nodes.Add(i.Name);
                }
                else
                {
                    ChildDepartments.Add(i);
                }
            }
            foreach (var i in ChildDepartments)
            {
                int ParentNode = 1;
                MakeNode(i.OverId, ParentNode, i.Name);
            }
                        
        }
    }
}
