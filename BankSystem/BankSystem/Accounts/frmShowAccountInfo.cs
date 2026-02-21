using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Accounts
{
    public partial class frmShowAccountInfo : Form
    {
        private int _AccountID;
        private clsAccount _account;
        public frmShowAccountInfo(int accountID)
        {
            InitializeComponent();
            _AccountID = accountID;

            _account = clsAccount.Find(_AccountID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        public void LoadAccountInfo()
        {
            ctrlAccountCard1.LoadAccountInfo(_AccountID);
        }   

        private void frmShowAccountInfo_Load(object sender, EventArgs e)
        {
            if(_account == null)
            {
                MessageBox.Show("Account not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadAccountInfo();

        }
    }
}
