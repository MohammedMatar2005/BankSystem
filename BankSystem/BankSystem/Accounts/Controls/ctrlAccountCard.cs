using DVLD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Accounts.Controls
{
    public partial class ctrlAccountCard : UserControl
    {

        private clsAccount _Account;

        private int _AccountID = -1;

        public int AccountID
        {
            get { return _AccountID; }
        }

        public clsAccount SelectedAccountInfo
        {
            get { return _Account; }
        }
        public ctrlAccountCard()
        {
            InitializeComponent();
        }

        public void LoadAccountInfo(int AccountID)
        {
            _AccountID = AccountID;
            _Account = clsAccount.Find(AccountID);
            if (_Account == null)
            {
                _ResetAccountInfo();
                return;
            }

            _FillAccountInfo();
        }

        private void _FillAccountInfo()
        {
         

        }

        private void _ResetAccountInfo()
        {
            _AccountID = -1;
            _Account = null;
        }
    }
}
