using Bank_Business;
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

namespace BankSystem.Login
{
    public partial class frmLoginWithCode : Form
    {
        
        public frmLoginWithCode()
        {
            InitializeComponent();
           
        }

        private void btnLoginWithCode_Click(object sender, EventArgs e)
        {
            string LoginCode  = txtLoginCode.Text.Trim();

            clsUser user = clsUser.GetUserInfoByLoginCode(LoginCode);
            if (user == null)
            {
                MessageBox.Show("There is no User Associated with this code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsGlobal.CurrentUser = user;
            this.Hide();

            Form frm = new frmMain(this);
            frm.ShowDialog();
        }

        private void guna2btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoginWithCode_Load(object sender, EventArgs e)
        {

        }
    }
}
