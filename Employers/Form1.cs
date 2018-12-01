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
        public void RefreshTree()
        {
            treeDepartments.BeginUpdate();
            try
            {
                treeDepartments.Nodes.Clear();
                FillTree();
            }
            finally
            {
                treeDepartments.EndUpdate();
            }
        }
        public List<Department> GetDepartmentList()
        {
            var DepartmentList = new Logic();
            return DepartmentList.GetDepartments();
        } 


        public List<Employee> GetEmployeesList()
        {
            var data = new Logic();
            return data.GetEmployees();
        }
            
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            var selectedParent = (treeDepartments.SelectedNode != null) ? Convert.ToInt32(treeDepartments.SelectedNode.Tag) : 0;
            var form = new frmAddDepartment(selectedParent);
            form.Show();
        }
        public void DepartmentAdded(Department department)
        {
            var Add = new Logic();
            MessageBox.Show(Add.AddDepartments(department).ToString());
            treeDepartments.Nodes.Clear();
            FillTree();
        }

        public void FillChildrens(int parentId, TreeNode parent)
        {
            
            
            foreach (var child in GetDepartmentList())
            {
                if (parentId == child.PartentId)
                {
                    var ChildNode = new TreeNode();
                    ChildNode.Text = child.Name;
                    ChildNode.Tag = child.Id;
                    parent.Nodes.Add(ChildNode);
                    FillChildrens(child.Id, ChildNode);
                }
            }
            
        }

        public void FillTree()
        {
            treeDepartments.Nodes.Add("Все отделения");


            foreach (var parent in GetDepartmentList())
            {
                if (parent.PartentId == 0)
                {
                    var ParentNode = new TreeNode();
                    ParentNode.Text = parent.Name;
                    ParentNode.Tag = parent.Id;
                    treeDepartments.Nodes[0].Nodes.Add(ParentNode);
                    FillChildrens(parent.Id, ParentNode);
                }
            }
        } 
        private void frmMain_Load(object sender, EventArgs e)
        {
            FillTree();
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {      
            if (treeDepartments.SelectedNode.Tag != null)
            {
                var editedDepartment = GetDepartmentList().Find(x => x.Id == Convert.ToInt32(treeDepartments.SelectedNode.Tag));
                var form = new frmAddDepartment(editedDepartment);
                form.Show();
                form.Tag = Convert.ToInt32(treeDepartments.SelectedNode.Tag);
            }
            else
            {
                MessageBox.Show("Выберете отдел для редактирования");
            }
        }

        public void DepartmentEdited(Department department)
        {
            var edit = new Logic();
            MessageBox.Show(edit.EditDepartment(department).ToString());
            RefreshTree();

        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (treeDepartments.SelectedNode.Tag != null)
            {
                var del = new CRUD();
                MessageBox.Show(del.DeleteDepartment(Convert.ToInt32(treeDepartments.SelectedNode.Tag)));
                RefreshTree();
                
            }
            else
            {
                MessageBox.Show("Выберете отдел для удаления");
            }
            
        }

        private void btnRefreshTreeView_Click(object sender, EventArgs e)
        {
            RefreshTree();
        }

        public void FillListVies()
        {
            //
            foreach (var emp in GetEmployeesList())
            {
                if (emp.IdDepartment == Convert.ToInt32(treeDepartments.SelectedNode.Tag))
                {
                    string Gender = "Неизвестно";
                    if (emp.Gender == 0)
                    {
                        Gender = "муж";
                    }
                    else
                    {
                        Gender = "жен";
                    }
                    string Department = GetDepartmentList().Find(x => x.Id == emp.IdDepartment).Name;
                    string[] par = { emp.Name, emp.Position, Department, Gender, emp.Mobile };
                    ListViewItem employee = new ListViewItem(par);
                    employee.Tag = emp.Id;
                    lwEmployees.Items.Add(employee);
                }

            }
        }
        private void treeDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lwEmployees.Items.Clear();
            FillListVies();
        }

        private void btnAddEmplyee_Click(object sender, EventArgs e)
        {
            var frmAdd = new frmAddEmployee();
            frmAdd.Show();
            frmAdd.Tag = Convert.ToInt32(treeDepartments.SelectedNode.Tag);
        }

        private void btnEditEmplyee_Click(object sender, EventArgs e)
        {
            if (SelectedEmployee == 0)
            {
                MessageBox.Show("Сначала выберете работника для редактирования");
            }
            else
            {
                var frmEdit = new frmAddEmployee();
                frmEdit.Tag = SelectedEmployee;
                frmEdit.Show();
            }
            
            
        }

        public int SelectedEmployee = 0;
        private void lwEmployees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectedEmployee = Convert.ToInt32(e.Item.Tag);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (SelectedEmployee == 0)
            {
                MessageBox.Show("Сначала выберете работника для удаления");
            }
            else
            {
                var del = new Logic();
                MessageBox.Show(del.DeleteEmployee(SelectedEmployee));
                lwEmployees.Items.Clear();
                FillListVies();
            }
        }
    }
}
