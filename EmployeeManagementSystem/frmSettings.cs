using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"\d"))
            {
                lblNumber.Text = "✔ Number";
                lblNumber.ForeColor = Color.Green;
            }
            else
            {
                lblNumber.Text = "✘ Number";
                lblNumber.ForeColor = Color.Red;
            }
            Match();
        }

        private void Match()
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblMatch.Text = "✔ Match";
                lblMatch.ForeColor = Color.Green;
            }
            else
            {
                lblMatch.Text = "✘ Match";
                lblMatch.ForeColor = Color.Red;
            }
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Match();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "Insert into [tblUsers] ([UserName], [Password],[Section],[Age], [FullName]) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cbSection.Text + "','" + txtAge.Text + "','" + txtFullName.Text + "')";
                CRUD.CRUD.CUD(query);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [tblUsers]");
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            CRUD.CRUD.RETRIEVECBO(cbSection, "SELECT [ID], [Section] FROM [tblSection] ORDER BY [Section] asc", "Section", "ID");
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [tblUsers]");

            lblNumber.Text = "❌ Number";
            lblNumber.ForeColor = Color.Red;

            lblNumber.Text = "✔ Number";
            lblNumber.ForeColor = Color.Green;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            ExportDgv.ExportToExcel(dgvUsers, "ExportedData_" + DateTime.Now.ToString("MM-dd-yyyy"));
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string TemplatePath = @"C:\LOCALDB\Employee_Details_Template.xlsx";
            string SavePath = @"C:\LOCALDB\Employee_Details_Template.xlsx";

            ExportCellFromDgv.ExportFromTemplate(TemplatePath,
        SavePath,
        "B1", dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value,
        "H1", dgvUsers.Rows[e.RowIndex].Cells["Section"].Value,
        "B2", dgvUsers.Rows[e.RowIndex].Cells["Username"].Value,
        "H2", dgvUsers.Rows[e.RowIndex].Cells["Age"].Value,
        "A32", LoginForm.fullname,
        "A33", DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
