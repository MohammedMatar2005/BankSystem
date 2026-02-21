using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Applications.Accounts
{
    public partial class frmCloseAccountApplciation : Form
    {
        private int _AccountID;
        private clsAccount _Account;
        public frmCloseAccountApplciation()
        {
            InitializeComponent();    
        }

        public void IsReadyToClose()
        {
            _Account = clsAccount.Find(_AccountID);
            
             if (_AccountID == -1)
             {
                MessageBox.Show("");
                 return;
             }
        }

        private void frmCloseAccountApplciation_Load(object sender, EventArgs e)
        {
          
        }
    }
}
