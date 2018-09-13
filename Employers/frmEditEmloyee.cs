using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BL;

namespace Employers
{
    public partial class frmEditEmloyee : Form
    {
        public frmEditEmloyee()
        {
            InitializeComponent();
            var Initial = new Logic();

            cbDepartments.DataSource = Initial.GetDepartments();
            cbDepartments.DisplayMember = "Name";
            cbDepartments.ValueMember = "Id";
            cbDepartments.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmEditEmloyee_Load(object sender, EventArgs e)
        {

        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            var edit = new Logic();
            var form = new frmMain();
            int SelectedId = Convert.ToInt32(Tag);

            var SelectedParent = (Department)cbDepartments.SelectedItem;
            int departmentId = 0;
            if (SelectedParent != null)
            {
                departmentId = SelectedParent.Id;
            }

            int employeeGender = 0;
            if (cbGender.SelectedText == "Мужской")
            {
                employeeGender = 0;
            }
            else
            {
                employeeGender = 1;
            }
            int IdDepartment = SelectedParent.Id;
            string Name = txtName.Text;
            string Mobile = txtPhone.Text;
            string Position = txtPosition.Text;
            int Gender = employeeGender;
            var EditedEmployee = new Employee(SelectedId, IdDepartment, Name, Mobile, Position, Gender);
            MessageBox.Show(edit.EditEmployee(EditedEmployee));

        }
    }
}
