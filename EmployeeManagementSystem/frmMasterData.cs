using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        public static string selectedTransaction, RequestorName, EmailAddress, Section, LocalNumber, EmployeeNumber, txtEmployeeID;


        private void dtgMasterData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void dtgMasterData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            selectedTransaction = lblTransactionNo.Text;
            EmployeeNumber = dtgMasterData.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
            RequestorName = dtgMasterData.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            EmailAddress = dtgMasterData.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
            Section = dtgMasterData.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            LocalNumber = dtgMasterData.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {

            if (lblTransactionNo.Text == "<TRANSACTION NUMBER>")
            {
                MessageBox.Show("Please select a corresponding data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            frmAddEmployeee OpenfrmAddEmployee = new frmAddEmployeee();
            OpenfrmAddEmployee.TransactionNo = lblTransactionNo.Text;  // <-- add this line
            OpenfrmAddEmployee.ShowDialog();
            refreshData();


        }
        private void refreshData()
        {
            string select_tblrequestorlist = "SELECT * FROM tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "SELECT * FROM tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }
    }
}
