using Bank_Business;
using BankSystem.Properties;
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

namespace BankSystem.Users.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private int _PersonID;

        public int PersonID
        {
            get { return _PersonID; }
            set {}
        }

        private clsPerson _Person;

        public clsPerson Person
        {
            get { return _Person; }
            set {}
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPerson(int personID)
        {
            _PersonID = personID;
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetPersonInfo();
                return;
            }

            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            lblFullName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            lblAddress.Text = _Person.Address;
            lblBirthDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblEmail.Text = _Person.Email;
            lblNationality.Text = _Person.NationalityCountryID.ToString();
            lblPhone.Text = _Person.Phone;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.man;
            else
                pbPersonImage.Image = Resources.person_woman;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void _ResetPersonInfo()
        {
            _PersonID = 0;
            _Person = null;
            lblFullName.Text = "[Full Name]";
            lblAddress.Text = "[Address]";
            lblBirthDate.Text = "[Birth Date]";
            lblEmail.Text = "[Email]";
            lblNationality.Text = "[Nationality Id]";
            lblPhone.Text = "[Phone Number]";
            lblPersonID.Text = "[Person ID]";
            lblNationalNo.Text = "[National No]";
            lblGender.Text = "[Gender]";
            pbPersonImage.Image = Resources.man;

        }



    }
}
