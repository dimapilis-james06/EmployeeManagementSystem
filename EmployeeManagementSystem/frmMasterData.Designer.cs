namespace EmployeeManagementSystem
{
    partial class frmMasterData
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
            this.pnlChildTitle = new System.Windows.Forms.Panel();
            this.lblMasterData = new System.Windows.Forms.Label();
            this.dtgMasterData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditData = new System.Windows.Forms.Button();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.pnlChildTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMasterData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChildTitle
            // 
            this.pnlChildTitle.BackColor = System.Drawing.Color.Maroon;
            this.pnlChildTitle.Controls.Add(this.lblMasterData);
            this.pnlChildTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlChildTitle.Name = "pnlChildTitle";
            this.pnlChildTitle.Size = new System.Drawing.Size(571, 49);
            this.pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            this.lblMasterData.AutoSize = true;
            this.lblMasterData.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMasterData.Location = new System.Drawing.Point(33, 9);
            this.lblMasterData.Name = "lblMasterData";
            this.lblMasterData.Size = new System.Drawing.Size(150, 29);
            this.lblMasterData.TabIndex = 0;
            this.lblMasterData.Text = "Master Data";
            // 
            // dtgMasterData
            // 
            this.dtgMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMasterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMasterData.Location = new System.Drawing.Point(0, 49);
            this.dtgMasterData.Name = "dtgMasterData";
            this.dtgMasterData.Size = new System.Drawing.Size(571, 185);
            this.dtgMasterData.TabIndex = 2;
            this.dtgMasterData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMasterData_CellContentClick);
            this.dtgMasterData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMasterData_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditData);
            this.panel2.Controls.Add(this.lblTransactionNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 49);
            this.panel2.TabIndex = 1;
            // 
            // btnEditData
            // 
            this.btnEditData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditData.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditData.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditData.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditData.Location = new System.Drawing.Point(475, 3);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(84, 40);
            this.btnEditData.TabIndex = 1;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.UseVisualStyleBackColor = false;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionNo.Location = new System.Drawing.Point(12, 16);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(141, 21);
            this.lblTransactionNo.TabIndex = 0;
            this.lblTransactionNo.Text = "<Transaction Number>";
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 283);
            this.Controls.Add(this.dtgMasterData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChildTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMasterData";
            this.Text = "frmMasterData";
            this.Load += new System.EventHandler(this.frmMasterData_Load);
            this.pnlChildTitle.ResumeLayout(false);
            this.pnlChildTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMasterData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildTitle;
        private System.Windows.Forms.Label lblMasterData;
        private System.Windows.Forms.DataGridView dtgMasterData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTransactionNo;
        private System.Windows.Forms.Button btnEditData;
    }
}