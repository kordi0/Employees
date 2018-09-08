namespace Employers
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeDepartments = new System.Windows.Forms.TreeView();
            this.dgwEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmplyee = new System.Windows.Forms.Button();
            this.btnAddEmplyee = new System.Windows.Forms.Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeDepartments
            // 
            this.treeDepartments.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.departmentBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.treeDepartments.Location = new System.Drawing.Point(12, 12);
            this.treeDepartments.Name = "treeDepartments";
            this.treeDepartments.Size = new System.Drawing.Size(237, 405);
            this.treeDepartments.TabIndex = 0;
            // 
            // dgwEmployees
            // 
            this.dgwEmployees.AllowUserToAddRows = false;
            this.dgwEmployees.AllowUserToDeleteRows = false;
            this.dgwEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployees.Location = new System.Drawing.Point(269, 12);
            this.dgwEmployees.Name = "dgwEmployees";
            this.dgwEmployees.ReadOnly = true;
            this.dgwEmployees.Size = new System.Drawing.Size(555, 405);
            this.dgwEmployees.TabIndex = 1;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(12, 423);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnAddDepartment.TabIndex = 2;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new System.Drawing.Point(93, 423);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnEditDepartment.TabIndex = 3;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(174, 423);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDepartment.TabIndex = 4;
            this.btnDeleteDepartment.Text = "Delete";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(749, 423);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEditEmplyee
            // 
            this.btnEditEmplyee.Location = new System.Drawing.Point(668, 423);
            this.btnEditEmplyee.Name = "btnEditEmplyee";
            this.btnEditEmplyee.Size = new System.Drawing.Size(75, 23);
            this.btnEditEmplyee.TabIndex = 6;
            this.btnEditEmplyee.Text = "Edit";
            this.btnEditEmplyee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmplyee
            // 
            this.btnAddEmplyee.Location = new System.Drawing.Point(587, 423);
            this.btnAddEmplyee.Name = "btnAddEmplyee";
            this.btnAddEmplyee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmplyee.TabIndex = 7;
            this.btnAddEmplyee.Text = "Add";
            this.btnAddEmplyee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddEmplyee.UseVisualStyleBackColor = true;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(DAL.Department);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 459);
            this.Controls.Add(this.btnAddEmplyee);
            this.Controls.Add(this.btnEditEmplyee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.dgwEmployees);
            this.Controls.Add(this.treeDepartments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Departments & Employees";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeDepartments;
        private System.Windows.Forms.DataGridView dgwEmployees;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEditEmplyee;
        private System.Windows.Forms.Button btnAddEmplyee;
        private System.Windows.Forms.BindingSource departmentBindingSource;
    }
}

