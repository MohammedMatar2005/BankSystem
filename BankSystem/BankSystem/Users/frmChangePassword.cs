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

namespace BankSystem.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUser _User;
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            _User = clsUser.FindByUserID(userID);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPerson(_User.person.PersonID);

        }

        private bool IsWritePassword()
        {
            return clsSecurity.ComputeHash(txtCurrentPassword.Text) == _User.Password.ToString();
        }

        



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields is not valid, put the mouse on the red icon",
                    "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _User.Password = clsSecurity.ComputeHash(txtNewPassword.Text.Trim());


            if (_User.Save())

            {
                MessageBox.Show("Data Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
                MessageBox.Show("Data not Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
