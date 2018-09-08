using System;
using System.Windows.Forms;
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
            
            listDepartments.Items.Clear();
            foreach (Department item in Initial.GetDepartments())
                listDepartments.Items.Add(item.Name);
        }

        private void btnDepartmentAdd_Click(object sender, EventArgs e)
        {
            int overId = 0;
            if (listDepartments.SelectedItem != null)
            {
                overId = 1;
            }
            string info = txtDepartmentInfo.Text.ToString();
            string name = txtDepartmentName.Text.ToString();
            var AddedDepartment = new Department(0, overId, info, name);
            var Add = new Logic();
            MessageBox.Show(Add.AddDepartments(AddedDepartment).ToString());
            frmAddDepartment form = new frmAddDepartment();
            form.Close();

        }

        private void listDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
