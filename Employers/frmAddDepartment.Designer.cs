namespace Employers
{
    partial class frmAddDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentInfo = new System.Windows.Forms.RichTextBox();
            this.btnDepartmentAdd = new System.Windows.Forms.Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название отдела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Старший отдел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание отдела";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(174, 63);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(262, 20);
            this.txtDepartmentName.TabIndex = 3;
            // 
            // txtDepartmentInfo
            // 
            this.txtDepartmentInfo.Location = new System.Drawing.Point(174, 136);
            this.txtDepartmentInfo.Name = "txtDepartmentInfo";
            this.txtDepartmentInfo.Size = new System.Drawing.Size(262, 92);
            this.txtDepartmentInfo.TabIndex = 4;
            this.txtDepartmentInfo.Text = "";
            // 
            // btnDepartmentAdd
            // 
            this.btnDepartmentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDepartmentAdd.Location = new System.Drawing.Point(161, 255);
            this.btnDepartmentAdd.Name = "btnDepartmentAdd";
            this.btnDepartmentAdd.Size = new System.Drawing.Size(211, 44);
            this.btnDepartmentAdd.TabIndex = 6;
            this.btnDepartmentAdd.Text = "Добавить Отдел";
            this.btnDepartmentAdd.UseVisualStyleBackColor = true;
            this.btnDepartmentAdd.Click += new System.EventHandler(this.btnDepartmentAdd_Click);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(DAL.Department);
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(DAL.Department);
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(174, 101);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(262, 21);
            this.cbDepartments.TabIndex = 7;
            this.cbDepartments.Text = "Оставьте пустым, если нет старшего отдела";
            // 
            // frmAddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.btnDepartmentAdd);
            this.Controls.Add(this.txtDepartmentInfo);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Name", true));
            this.Name = "frmAddDepartment";
            this.Text = "frmAddDepartment";
            this.Load += new System.EventHandler(this.frmAddDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.RichTextBox txtDepartmentInfo;
        private System.Windows.Forms.Button btnDepartmentAdd;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.ComboBox cbDepartments;
    }
}