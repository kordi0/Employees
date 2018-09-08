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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentInfo = new System.Windows.Forms.RichTextBox();
            this.listDepartments = new System.Windows.Forms.ListBox();
            this.btnDepartmentAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название отдела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Старший отдел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание отдела";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(174, 97);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(237, 20);
            this.txtDepartmentName.TabIndex = 3;
            // 
            // txtDepartmentInfo
            // 
            this.txtDepartmentInfo.Location = new System.Drawing.Point(174, 171);
            this.txtDepartmentInfo.Name = "txtDepartmentInfo";
            this.txtDepartmentInfo.Size = new System.Drawing.Size(237, 96);
            this.txtDepartmentInfo.TabIndex = 4;
            this.txtDepartmentInfo.Text = "";
            // 
            // listDepartments
            // 
            this.listDepartments.FormattingEnabled = true;
            this.listDepartments.Location = new System.Drawing.Point(174, 135);
            this.listDepartments.Name = "listDepartments";
            this.listDepartments.Size = new System.Drawing.Size(237, 30);
            this.listDepartments.TabIndex = 5;
            this.listDepartments.SelectedIndexChanged += new System.EventHandler(this.listDepartments_SelectedIndexChanged);
            // 
            // btnDepartmentAdd
            // 
            this.btnDepartmentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDepartmentAdd.Location = new System.Drawing.Point(161, 294);
            this.btnDepartmentAdd.Name = "btnDepartmentAdd";
            this.btnDepartmentAdd.Size = new System.Drawing.Size(211, 44);
            this.btnDepartmentAdd.TabIndex = 6;
            this.btnDepartmentAdd.Text = "Добавить Отдел";
            this.btnDepartmentAdd.UseVisualStyleBackColor = true;
            this.btnDepartmentAdd.Click += new System.EventHandler(this.btnDepartmentAdd_Click);
            // 
            // frmAddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnDepartmentAdd);
            this.Controls.Add(this.listDepartments);
            this.Controls.Add(this.txtDepartmentInfo);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddDepartment";
            this.Text = "frmAddDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.RichTextBox txtDepartmentInfo;
        private System.Windows.Forms.ListBox listDepartments;
        private System.Windows.Forms.Button btnDepartmentAdd;
    }
}