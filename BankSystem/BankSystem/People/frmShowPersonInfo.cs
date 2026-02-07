using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.People
{
    public partial class frmShowPersonInfo : Form
    {
        private int _PersonID;

        private clsPerson _Person;
        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
            _Person = clsPerson.Find(_PersonID);
        }

        

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            if (_Person != null)
            {
                ctrlPersonCard1.LoadPerson(_PersonID);
            }
            else
                MessageBox.Show($"No Person With Id = {_PersonID.ToString()} !");

            return;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
