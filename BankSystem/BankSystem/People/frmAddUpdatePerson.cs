using BankSystem.Properties;
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
using System.IO;

namespace BankSystem.People
{
    public partial class frmAddUpdatePerson : Form
    {

        private int _PersonID;
        private clsPerson _Person;

        public frmAddUpdatePerson(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
            _Person = clsPerson.Find(personID);
        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }

        private void _FillPersonInfo()
        {
            lblFName.Text = _Person.FirstName;
            lblSName.Text = _Person.SecondName;
            lblTName.Text = _Person.ThirdName;
            lblLName.Text = _Person.LastName;

            lblPhone.Text = _Person.PhoneNumber.ToString();
            lblEmail.Text = _Person.Email;

            lblNationalNo.Text = _Person.NationalNumber;
            lblGander.Text = _Person.Gender == Convert.ToBoolean(1) ? "Male" : "Female";

            lblDateOfBirth.Text = clsFormat.DateToShort(_Person.BirthDate);
            lblPersonID.Text = _Person.PersonID.ToString();

            lblCountry.Text = "Palestine";
            lblAddress.Text = _Person.Address;

            _LoadPersonImage();



        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == Convert.ToBoolean(1))
                pbPersonImage.Image = Resources.man;
            else
                pbPersonImage.Image = Resources.person_woman;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
            
        }

        private void _SetDefaultValues()
        {
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
           
            txtPhone.Text = "";
            txtEmail.Text = "";
           
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            
            dtpDateOfBirth.Value = DateTime.Now;
            lblPersonID.Text = "000";

            cbCountry.Text = "Palestine";
            txtAddress.Text = "";

            pbPersonImage.Image = Resources.man;
        }

        public void LoadPersonInfo()
        {
            if (_Person == null) 
            {
                _SetDefaultValues();
                return;
            }

            _FillPersonInfo();
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            LoadPersonInfo();
        }
    }
}
