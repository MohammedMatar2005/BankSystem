using Bank_Business;
using Bank_DataAccess;
using BankSystem.Login;
using DVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();

            string hash = clsSecurity.ComputeHash(Password);

            clsUser user = clsUser.FindByUsernameAndPassword(UserName, Password);


            if (user != null)
            {
                if (chkRememberMe.Checked)
                {
                    // store Username & Password
                    clsGlobal.RememberUsernameAndPassword(UserName, Password);
                }
                else
                {
                    // store empty Username & Password
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!user.isActive)
                {
                    txtUsername.Focus();
                    MessageBox.Show("Your account is not valid, Contact your admin", "In active");
                    return;
                }

                clsGlobal.CurrentUser = user;
                this.Hide();

                Form frm = new frmMain(this);
                frm.ShowDialog();

                EventLoggerExtensions.LogInfo($"{DateTime.Now}, {UserName} logged into the system!", EventLogEntryType.Information);
            }
            else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username / Password", " Wrong Credintial", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnLoginWithCode_Click(object sender, EventArgs e)
        {
            Form frm = new frmLoginWithCode();
            frm.ShowDialog();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
