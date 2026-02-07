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

namespace BankSystem.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private int _UserId = -1;
        private clsUser _User;
        public ctrlUserCard()
        {
            InitializeComponent();
            
        }

        private void _SetDefaultValues()
        {
            lblUserName.Text = "???";
            lblIsActive.Text = "???";
            
        }

        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPerson(_User.person.PersonID);
            lblIsActive.Text = _User.isActive ? "Yes" : "No";
            lblUserName.Text = _User.UserName.ToString();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserId = UserID;
            _User = clsUser.FindByUserID(UserID);


            if (_User == null)
            {
                _SetDefaultValues();
                MessageBox.Show($"No User With ID = {_UserId}, try another User Id");
                return;
            }
            else
                _FillUserInfo();
           

            
        }

       
    }
}
