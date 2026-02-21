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
    public partial class ctrlAccountInfoCardWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnAccountSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void AccountSelected(int AccounntID)
        {
            Action<int> handler = OnAccountSelected;
            if (handler != null)
            {
                handler(AccounntID); // Raise the event with the parameter
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        private int _AccountID;

        public int AccountID
        {
            get
            {
                return ctrlAccountCard1.AccountID;
            }

        }


        public ctrlAccountInfoCardWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlAccountInfoCardWithFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }
    }
}
