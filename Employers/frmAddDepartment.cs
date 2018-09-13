using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DAL;
using BL;

namespace Employers
{
    public partial class frmAddDepartment : Form
    {
        public frmAddDepartment()
        {
            InitializeComponent();
            var Initial = new Logic();

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
            int overId = 0;
            var SelectedParent = (Department)cbDepartments.SelectedItem;
            if (SelectedParent != null)
            {
                overId = SelectedParent.Id;
            }
            string info = txtDepartmentInfo.Text.ToString();
            string name = txtDepartmentName.Text.ToString();
            var AddedDepartment = new Department(0, overId, info, name);
            var Add = new Logic();
            MessageBox.Show(Add.AddDepartments(AddedDepartment).ToString());
            frmAddDepartment form = new frmAddDepartment();
            form.Close();

        }

        

        private void frmAddDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
