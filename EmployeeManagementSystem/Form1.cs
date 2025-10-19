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
    public partial class frmMotherForm : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmMotherForm()
        {
            InitializeComponent();
            lblFullName.Text = LoginForm.fullname;
            lblSection.Text = LoginForm.section;
            lblAge.Text = LoginForm.age;
        }
    
        private void frmMotherForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void openChildForm (Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlStage.Controls.Add(childForm);
            pnlStage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }
        string selectedTransaction, RequestorName, EmailAddress, Section, LocalNumber, EmployeeNumber;

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSettings());
        }

        private void lblEMS_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            setDefault();
            openChildForm(new frmAddEmployeee());
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            setDefault();
            openChildForm(new frmMasterData());
        }

        public void setDefault()
        {
            frmMasterData.selectedTransaction = "0";
            frmMasterData.RequestorName = "";
            frmMasterData.EmailAddress = "";
            frmMasterData.Section = "";
            frmMasterData.LocalNumber = "";
            frmMasterData.EmployeeNumber = "";
        }
    }
}
