using Bank_Business;
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
        private frmLogin _frmLogin = null;
        public frmLoginWithCode()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string LoginCode  = txtLoginCode.Text.Trim();

            clsUser user = clsUser.GetUserInfoByLoginCode(LoginCode);
            if (user == null)
            {
                MessageBox.Show("There is no User Associated with this code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Form frm = new frmMain(_frmLogin);
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
