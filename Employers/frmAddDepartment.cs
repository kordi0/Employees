using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DAL;
using BL;

namespace Employers
{
    public partial class frmAddDepartment : Form
    {
        public int chek;
        public string info;
        public string name;
        public Department choosenDepartment;
        public int parentDepartment;
        public frmAddDepartment(int department)
        {
            chek = 1;
            parentDepartment = department;
            InitializeComponent();
            var Initial = new Logic();
            btnDepartmentAdd.Text = "Добавить отдел";

            var root = new Department(0, 0, "0:", "Все отделы");
            var AllDepartmentsInComboBox = new List<Department>();
            AllDepartmentsInComboBox = Initial.GetDepartments();
            AllDepartmentsInComboBox.Insert(0, root);

            cbDepartments.DataSource = AllDepartmentsInComboBox;
            cbDepartments.DisplayMember = "Name";
            cbDepartments.ValueMember = "Id";
            cbDepartments.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public frmAddDepartment(Department department)
        {
            chek = 2;
            parentDepartment = department.Id;
            choosenDepartment = department;
            InitializeComponent();
            var Initial = new Logic();
            btnDepartmentAdd.Text = "Сохранить изменения";

            var root = new Department(0, 0, "0:", "Все отделы");
            var AllDepartmentsInComboBox = new List<Department>();
            AllDepartmentsInComboBox = Initial.GetDepartments();
            AllDepartmentsInComboBox.Insert(0, root);

            cbDepartments.DataSource = AllDepartmentsInComboBox;
            cbDepartments.DisplayMember = "Name";
            cbDepartments.ValueMember = "Id";
            cbDepartments.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDepartmentAdd_Click(object sender, EventArgs e)
        {
            if (chek == 1)
            {
                int PartentId;
                var SelectedParent = (Department)cbDepartments.SelectedItem;

                PartentId = (SelectedParent.Id == 0) ? parentDepartment : 0;

                if (txtDepartmentInfo.Text.ToString() != "" || txtDepartmentName.Text.ToString() != "")
                {
                    info = txtDepartmentInfo.Text.ToString();
                    name = txtDepartmentName.Text.ToString();
                    var addedDepartment = new Department(0, PartentId, info, name);
                    var add = new frmMain();
                    add.DepartmentAdded(addedDepartment);
                }
                else MessageBox.Show("Заполните имя и описание");
            }
            else
            {
                int partentId;
                var SelectedParent = (Department)cbDepartments.SelectedItem;

                partentId = (SelectedParent.Id == 0) ? choosenDepartment.PartentId : 0;
                name = (txtDepartmentName.Text.ToString() == "") ? choosenDepartment.Name : txtDepartmentName.Text.ToString();
                info = (txtDepartmentInfo.Text.ToString() == "") ? choosenDepartment.Info : txtDepartmentInfo.Text.ToString();
                var editedDepartment = new Department(choosenDepartment.Id, partentId, info, name);
                var edit = new frmMain();
                edit.DepartmentEdited(editedDepartment);
            }
            
                         
        }

        

        private void frmAddDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
