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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
