using BankSystem.Clients;
using BankSystem.People;
using BankSystem.Users;
using DVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmMain : Form
    {
        private Form _frmLogin;
        public frmMain(Form frm)
        {
            InitializeComponent();
            _frmLogin = frm;



        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }



        private void menuDeposit_Click(object sender, EventArgs e) { }
        private void menuWithdraw_Click(object sender, EventArgs e) {  }
        private void menuClients_Click(object sender, EventArgs e)
        {
            Form frm = new frmListClients();
            frm.ShowDialog();


        }
        private void menuUsers_Click(object sender, EventArgs e) 
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }
        private void menuCurrency_Click(object sender, EventArgs e) {  }
        private void menuSettings_Click(object sender, EventArgs e) {  }
      







        private void UsersStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void btnLogout_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void LogoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                          "Confirm Exit",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

          
            if (result == DialogResult.Yes)
            {
                this.Hide();
                _frmLogin.ShowDialog();
            }


        }

        private void PeopleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
    }

      
}
    

