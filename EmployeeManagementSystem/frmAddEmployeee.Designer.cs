namespace EmployeeManagementSystem
{
    partial class frmAddEmployeee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxInsertUpdate = new System.Windows.Forms.GroupBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.txtLocalNumber = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblLocalNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtRequestorName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblRequestorName = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gboxInsertUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lblAddEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 45);
            this.panel1.TabIndex = 0;
            // 
            // gboxInsertUpdate
            // 
            this.gboxInsertUpdate.Controls.Add(this.cmbSection);
            this.gboxInsertUpdate.Controls.Add(this.btnDelete);
            this.gboxInsertUpdate.Controls.Add(this.btnInsertUpdate);
            this.gboxInsertUpdate.Controls.Add(this.txtLocalNumber);
            this.gboxInsertUpdate.Controls.Add(this.lblSection);
            this.gboxInsertUpdate.Controls.Add(this.lblLocalNumber);
            this.gboxInsertUpdate.Controls.Add(this.btnSearch);
            this.gboxInsertUpdate.Controls.Add(this.txtEmailAddress);
            this.gboxInsertUpdate.Controls.Add(this.lblEmailAddress);
            this.gboxInsertUpdate.Controls.Add(this.txtRequestorName);
            this.gboxInsertUpdate.Controls.Add(this.txtEmployeeID);
            this.gboxInsertUpdate.Controls.Add(this.lblRequestorName);
            this.gboxInsertUpdate.Controls.Add(this.lblEmployeeNumber);
            this.gboxInsertUpdate.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxInsertUpdate.Location = new System.Drawing.Point(12, 51);
            this.gboxInsertUpdate.Name = "gboxInsertUpdate";
            this.gboxInsertUpdate.Size = new System.Drawing.Size(584, 260);
            this.gboxInsertUpdate.TabIndex = 1;
            this.gboxInsertUpdate.TabStop = false;
            this.gboxInsertUpdate.Text = "Employee Details Manual Insert and Update";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(178, 172);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(97, 25);
            this.cmbSection.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(281, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.BackColor = System.Drawing.Color.Brown;
            this.btnInsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertUpdate.Location = new System.Drawing.Point(178, 203);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(97, 32);
            this.btnInsertUpdate.TabIndex = 11;
            this.btnInsertUpdate.Text = "INSERT";
            this.btnInsertUpdate.UseVisualStyleBackColor = false;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // txtLocalNumber
            // 
            this.txtLocalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalNumber.Location = new System.Drawing.Point(178, 135);
            this.txtLocalNumber.Name = "txtLocalNumber";
            this.txtLocalNumber.Size = new System.Drawing.Size(97, 24);
            this.txtLocalNumber.TabIndex = 9;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(116, 174);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(56, 17);
            this.lblSection.TabIndex = 8;
            this.lblSection.Text = "Section :";
            // 
            // lblLocalNumber
            // 
            this.lblLocalNumber.AutoSize = true;
            this.lblLocalNumber.Location = new System.Drawing.Point(72, 136);
            this.lblLocalNumber.Name = "lblLocalNumber";
            this.lblLocalNumber.Size = new System.Drawing.Size(101, 17);
            this.lblLocalNumber.TabIndex = 7;
            this.lblLocalNumber.Text = "Local Number :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Brown;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(450, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 26);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAddress.Location = new System.Drawing.Point(178, 97);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(369, 24);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(72, 100);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(100, 17);
            this.lblEmailAddress.TabIndex = 4;
            this.lblEmailAddress.Text = "Email Address :";
            // 
            // txtRequestorName
            // 
            this.txtRequestorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequestorName.Location = new System.Drawing.Point(178, 61);
            this.txtRequestorName.Name = "txtRequestorName";
            this.txtRequestorName.Size = new System.Drawing.Size(369, 24);
            this.txtRequestorName.TabIndex = 3;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Location = new System.Drawing.Point(178, 27);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(266, 24);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // lblRequestorName
            // 
            this.lblRequestorName.AutoSize = true;
            this.lblRequestorName.Location = new System.Drawing.Point(60, 64);
            this.lblRequestorName.Name = "lblRequestorName";
            this.lblRequestorName.Size = new System.Drawing.Size(112, 17);
            this.lblRequestorName.TabIndex = 1;
            this.lblRequestorName.Text = "Requestor Name :";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(44, 30);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(128, 17);
            this.lblEmployeeNumber.TabIndex = 0;
            this.lblEmployeeNumber.Text = "Employee Number :";
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddEmployee.Location = new System.Drawing.Point(15, 9);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(170, 29);
            this.lblAddEmployee.TabIndex = 0;
            this.lblAddEmployee.Text = "Add Employee";
            // 
            // frmAddEmployeee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 322);
            this.Controls.Add(this.gboxInsertUpdate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEmployeee";
            this.Text = "frmAddEmployeee";
            this.Load += new System.EventHandler(this.frmAddEmployeee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gboxInsertUpdate.ResumeLayout(false);
            this.gboxInsertUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboxInsertUpdate;
        private System.Windows.Forms.TextBox txtRequestorName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblRequestorName;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtLocalNumber;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblLocalNumber;
        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label lblAddEmployee;
    }
}