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
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();

            var Initial = new Logic();

            cbDepartments.DataSource = Initial.GetDepartments();
            cbDepartments.DisplayMember = "Name";
            cbDepartments.ValueMember = "Id";
            cbDepartments.DropDownStyle = ComboBoxStyle.DropDownList;

            var Male = new Gender(0, "Муж.");
            var Female = new Gender(1, "Жен.");
            var Genders = new List<Gender>();
            Genders.Add(Male);
            Genders.Add(Female);
            cbGender.DataSource = Genders;
            cbGender.DisplayMember = "Name";
            cbGender.ValueMember = "Id";
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var SelectedParent = (Department)cbDepartments.SelectedItem;
            var SelectedGender = (Gender)cbGender.SelectedItem;
            int departmentId = 0;
            if (SelectedParent != null)
            {
                departmentId = SelectedParent.Id;
            }
            
                                    
            int IdDepartment = departmentId;
            string Name = txtName.Text;
            string Mobile = txtPhone.Text;
            string Position = txtPosition.Text;
            int Gender = SelectedGender.Id;
            var AddedEmployee = new Employee(0, IdDepartment, Name, Mobile, Position, Gender);
            var Add = new Logic();
            MessageBox.Show(Add.AddEmployee(AddedEmployee).ToString());
            
        }
    }
}
