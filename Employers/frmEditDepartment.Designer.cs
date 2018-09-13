namespace Employers
{
    partial class frmEditDepartment
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
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.btnDepartmentEdit = new System.Windows.Forms.Button();
            this.txtDepartmentInfo = new System.Windows.Forms.RichTextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(169, 111);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(262, 21);
            this.cbDepartments.TabIndex = 14;
            this.cbDepartments.Text = "Оставьте пустым, если нет старшего отдела";
            // 
            // btnDepartmentEdit
            // 
            this.btnDepartmentEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDepartmentEdit.Location = new System.Drawing.Point(156, 265);
            this.btnDepartmentEdit.Name = "btnDepartmentEdit";
            this.btnDepartmentEdit.Size = new System.Drawing.Size(211, 44);
            this.btnDepartmentEdit.TabIndex = 13;
            this.btnDepartmentEdit.Text = "Сохранить изменения";
            this.btnDepartmentEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDepartmentEdit.UseVisualStyleBackColor = true;
            this.btnDepartmentEdit.Click += new System.EventHandler(this.btnDepartmentEdit_Click);
            // 
            // txtDepartmentInfo
            // 
            this.txtDepartmentInfo.Location = new System.Drawing.Point(169, 146);
            this.txtDepartmentInfo.Name = "txtDepartmentInfo";
            this.txtDepartmentInfo.Size = new System.Drawing.Size(262, 92);
            this.txtDepartmentInfo.TabIndex = 12;
            this.txtDepartmentInfo.Text = "";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(169, 73);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(262, 20);
            this.txtDepartmentName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Описание отдела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Старший отдел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название отдела";
            // 
            // frmEditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 397);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.btnDepartmentEdit);
            this.Controls.Add(this.txtDepartmentInfo);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditDepartment";
            this.Text = "Изменение отдела";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Button btnDepartmentEdit;
        private System.Windows.Forms.RichTextBox txtDepartmentInfo;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}