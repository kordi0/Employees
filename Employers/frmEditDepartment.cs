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
    public partial class frmEditDepartment : Form
    {
        
        public frmEditDepartment()
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

        private void btnDepartmentEdit_Click(object sender, EventArgs e)
        {
            var edit = new Logic();
            var SelectedParent = (Department)cbDepartments.SelectedItem;
            var form = new frmMain();
            int SelectedId = Convert.ToInt32(Tag);
            
            int overId = SelectedParent.Id;
            if (SelectedId == overId)
            {
                MessageBox.Show("Вы не можете сделать старшим отделом текущий отдел");
            }
            else
            {
                var EditedDepartment = new Department(SelectedId, overId, txtDepartmentInfo.Text.ToString(), txtDepartmentName.Text.ToString());

                //SelectedParent.Id = editedDepartmentId;
                //SelectedParent.Info = txtDepartmentInfo.Text.ToString();
                //SelectedParent.Name = txtDepartmentName.Text.ToString();

                MessageBox.Show(edit.EditDepartment(EditedDepartment));
            }
            
        }
    }
}
