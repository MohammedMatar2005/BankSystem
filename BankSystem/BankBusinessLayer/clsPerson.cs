
using System;
using System.Data;
// تأكد من عمل using لطبقة الداتا أكسس هنا إذا كانت في مشروع مختلف
// using YourProjectNameDataAccessLayer; 

public class clsPerson
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int PersonID { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string ThirdName { get; set; }
    public string LastName { get; set; }
    public bool Gender { get; set; }
    public string NationalNumber { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string ImagePath { get; set; }
    public DateTime BirthDate { get; set; }


    // Constructor للوضع الافتراضي (إضافة جديد)
    public clsPerson()
    {
        this.PersonID = -1;
        // يمكنك هنا تعيين قيم افتراضية لباقي الخصائص إذا أردت
        Mode = enMode.AddNew;
    }

    // Private Constructor لاستخدامه في ميثود Find (وضع التعديل)
    private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, bool Gender, string NationalNumber, string Address, string Email, string PhoneNumber, string ImagePath, DateTime BirthDate)
    {
        this.PersonID = PersonID;
        this.FirstName = FirstName;
        this.SecondName = SecondName;
        this.ThirdName = ThirdName;
        this.LastName = LastName;
        this.Gender = Gender;
        this.NationalNumber = NationalNumber;
        this.Address = Address;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
        this.ImagePath = ImagePath;
        this.BirthDate = BirthDate;

        Mode = enMode.Update;
    }

    // ميثود Find
    public static clsPerson Find(int PersonID)
    {
        string FirstName = "";
        string SecondName = "";
        string ThirdName = "";
        string LastName = "";
        bool Gender = false;
        string NationalNumber = "";
        string Address = "";
        string Email = "";
        string PhoneNumber = "";
        string ImagePath = "";
        DateTime BirthDate = DateTime.Now;

        bool isFound = clsPersonData.GetPeopleInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref Gender, ref NationalNumber, ref Address, ref Email, ref PhoneNumber, ref ImagePath, ref BirthDate);

        if (isFound)
            return new clsPerson(PersonID,FirstName, SecondName, ThirdName, LastName, Gender, NationalNumber, Address, Email, PhoneNumber, ImagePath, BirthDate);
        else
            return null;
    }

    // ميثود Save (تقوم بالإضافة أو التعديل تلقائياً)
    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewPeople())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdatePeople();
        }
        return false;
    }

    private bool _AddNewPeople()
    {
        this.PersonID = clsPersonData.AddNewPeople(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Gender, this.NationalNumber, this.Address, this.Email, this.PhoneNumber, this.ImagePath, this.BirthDate);
        return (this.PersonID != -1);
    }

    private bool _UpdatePeople()
    {
        return clsPersonData.UpdatePeople(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Gender, this.NationalNumber, this.Address, this.Email, this.PhoneNumber, this.ImagePath, this.BirthDate);
    }

    public static DataTable GetAllPeople()
    {
        return clsPersonData.GetAllPeople();
    }

    public static bool Delete(int PersonID)
    {
        return clsPersonData.DeletePeople(PersonID);
    }

    public static bool IsExist(int PersonID)
    {
        return clsPersonData.IsPeopleExist(PersonID);
    }
}