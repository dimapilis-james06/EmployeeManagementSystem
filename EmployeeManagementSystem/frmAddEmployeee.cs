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
    public partial class frmAddEmployeee : Form
    {
        public frmAddEmployeee()
        {
            InitializeComponent();
            loadInputData();
        }
        private void loadInputData()
        {
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmailAddress.Text = frmMasterData.EmailAddress;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
            txtEmployeeID.Text = frmMasterData.EmployeeNumber;
        }
        public void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtEmployeeID.Text) || string.IsNullOrWhiteSpace(txtRequestorName.Text) || string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(cmbSection.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text)))
            {
                MessageBox.Show("Please fill up all the fields.", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!this.txtEmailAddress.Text.EndsWith("@firstasia.edu.ph"))
            {
                MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtLocalNumber.Text.Length != 4 || !txtLocalNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 4-digit local number.", "Invalid Local Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "SELECT * FROM [tblEmployeeData] WHERE [ID] = " + frmMasterData.selectedTransaction + " OR [EmployeeNumber] = '" + txtEmployeeID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (dtg_addrequestor == true)
            {
                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exist. Do you want to update?", "Already Exists.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes)
                {
                    if (!txtEmailAddress.Text.EndsWith("@firstasia.edu.ph"))
                    {
                        MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtLocalNumber.Text.Length != 4 || !txtLocalNumber.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Please enter a valid 4-digit local number.", "Invalid Local Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string update_requestor = "UPDATE [tblEmployeeData] SET [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' , [EmployeeNumber] = '" + txtEmployeeID.Text + "' WHERE [ID] = " + frmMasterData.selectedTransaction + " OR [EmployeeNumber] = '" + txtEmployeeID.Text + "'";
                    CRUD.CRUD.CUD(update_requestor);
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearAllFields();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("No changes were made.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAllFields();
                    this.Close();
                }
                else
                {
                    this.Close();
                    return;
                }

            }
            else
            {
                string add_requestor = "INSERT INTO [tblEmployeeData] ([EmployeeNumber],[RequestorName], [RequestorEmail], [Section],[LocalNumber]) VALUES ('" + txtEmployeeID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Please enter an Employee Number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchQuery = $"SELECT * FROM [tblEmployeeData] WHERE [EmployeeNumber] = '{txtEmployeeID.Text}'";

            // Use CRUD.RETRIEVESINGLE to check if employee exists
            bool employeeExists = CRUD.CRUD.RETRIEVESINGLE(searchQuery);

            if (employeeExists)
            {
                MessageBox.Show("Employee found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmployeeID.Clear();
            }
            else
            {
                MessageBox.Show("Employee not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Optionally clear fields or handle as needed
                txtEmployeeID.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (frmMasterData.selectedTransaction == null || frmMasterData.selectedTransaction == "0" || string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("No selected data.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Delete Data", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string delete_requestor = "DELETE FROM [tblEmployeeData] WHERE ID = " + frmMasterData.selectedTransaction;
                CRUD.CRUD.CUD(delete_requestor);
                MessageBox.Show("Data has been deleted.", "Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                return;
            }
        }
        private void clearAllFields()
        {
            txtEmployeeID.Clear();
            txtEmailAddress.Clear();
            txtLocalNumber.Clear();
            txtRequestorName.Clear();
            cmbSection.Text = "";
        }
        private void frmAddEmployeee_Load(object sender, EventArgs e)
        {

        }
    }
}
