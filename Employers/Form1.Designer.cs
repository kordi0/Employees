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
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmplyee = new System.Windows.Forms.Button();
            this.btnAddEmplyee = new System.Windows.Forms.Button();
            this.btnRefreshTreeView = new System.Windows.Forms.Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lwEmployees = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeDepartments
            // 
            this.treeDepartments.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.departmentBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.treeDepartments.Location = new System.Drawing.Point(12, 12);
            this.treeDepartments.Name = "treeDepartments";
            this.treeDepartments.Size = new System.Drawing.Size(318, 405);
            this.treeDepartments.TabIndex = 0;
            this.treeDepartments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDepartments_AfterSelect);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(93, 423);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnAddDepartment.TabIndex = 2;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new System.Drawing.Point(174, 423);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnEditDepartment.TabIndex = 3;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(255, 423);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDepartment.TabIndex = 4;
            this.btnDeleteDepartment.Text = "Delete";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(727, 423);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmplyee
            // 
            this.btnEditEmplyee.Location = new System.Drawing.Point(646, 423);
            this.btnEditEmplyee.Name = "btnEditEmplyee";
            this.btnEditEmplyee.Size = new System.Drawing.Size(75, 23);
            this.btnEditEmplyee.TabIndex = 6;
            this.btnEditEmplyee.Text = "Edit";
            this.btnEditEmplyee.UseVisualStyleBackColor = true;
            this.btnEditEmplyee.Click += new System.EventHandler(this.btnEditEmplyee_Click);
            // 
            // btnAddEmplyee
            // 
            this.btnAddEmplyee.Location = new System.Drawing.Point(565, 423);
            this.btnAddEmplyee.Name = "btnAddEmplyee";
            this.btnAddEmplyee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmplyee.TabIndex = 7;
            this.btnAddEmplyee.Text = "Add";
            this.btnAddEmplyee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddEmplyee.UseVisualStyleBackColor = true;
            this.btnAddEmplyee.Click += new System.EventHandler(this.btnAddEmplyee_Click);
            // 
            // btnRefreshTreeView
            // 
            this.btnRefreshTreeView.Location = new System.Drawing.Point(12, 423);
            this.btnRefreshTreeView.Name = "btnRefreshTreeView";
            this.btnRefreshTreeView.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTreeView.TabIndex = 8;
            this.btnRefreshTreeView.Text = "Refresh";
            this.btnRefreshTreeView.UseVisualStyleBackColor = true;
            this.btnRefreshTreeView.Click += new System.EventHandler(this.btnRefreshTreeView_Click);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(DAL.Department);
            // 
            // lwEmployees
            // 
            this.lwEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colPosition,
            this.colDepartment,
            this.colGender,
            this.colPhone});
            this.lwEmployees.Location = new System.Drawing.Point(337, 13);
            this.lwEmployees.Name = "lwEmployees";
            this.lwEmployees.Size = new System.Drawing.Size(465, 404);
            this.lwEmployees.TabIndex = 9;
            this.lwEmployees.UseCompatibleStateImageBehavior = false;
            this.lwEmployees.View = System.Windows.Forms.View.Details;
            this.lwEmployees.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lwEmployees_ItemSelectionChanged);
            // 
            // colName
            // 
            this.colName.Text = "ФИО";
            this.colName.Width = 79;
            // 
            // colPosition
            // 
            this.colPosition.Text = "Должность";
            this.colPosition.Width = 107;
            // 
            // colDepartment
            // 
            this.colDepartment.Text = "Отдел";
            this.colDepartment.Width = 98;
            // 
            // colGender
            // 
            this.colGender.Text = "Пол";
            // 
            // colPhone
            // 
            this.colPhone.Text = "Телефон";
            this.colPhone.Width = 115;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 452);
            this.Controls.Add(this.lwEmployees);
            this.Controls.Add(this.btnRefreshTreeView);
            this.Controls.Add(this.btnAddEmplyee);
            this.Controls.Add(this.btnEditEmplyee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.treeDepartments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Departments & Employees";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeDepartments;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEditEmplyee;
        private System.Windows.Forms.Button btnAddEmplyee;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Button btnRefreshTreeView;
        private System.Windows.Forms.ListView lwEmployees;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colDepartment;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ColumnHeader colPhone;
    }
}

