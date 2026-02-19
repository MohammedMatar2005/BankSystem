
using System;
using System.Data;
using BankDataAccessLayer;

public class clsApplicationType
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int ApplicationTypeID { get; set; }
    public string Description { get; set; }

    public decimal ApplicationFees { get; set; }


    public clsApplicationType()
    {
        this.ApplicationTypeID = -1;
        this.Description = "";
        this.ApplicationFees = 0;
        Mode = enMode.AddNew;
    }

    // Private Constructor لاستخدامه في ميثود Find (وضع التعديل)
    private clsApplicationType(int ApplicationTypeID, string Description, decimal ApplicationFees)
    {
        this.ApplicationTypeID = ApplicationTypeID;
        this.Description = Description;
        this.ApplicationFees = ApplicationFees;

        Mode = enMode.Update;
    }

    // ميثود Find
    public static clsApplicationType Find(int ApplicationTypeID)
    {
        string Description = ""; decimal ApplicationFees = 0;

        bool isFound = clsApplicationTypesData.GetApplicationTypeInfoByID(ApplicationTypeID, ref Description, ref ApplicationFees);

        if (isFound)
            return new clsApplicationType(ApplicationTypeID, Description, ApplicationFees);
        else
            return null;
    }

    // ميثود Save (تقوم بالإضافة أو التعديل تلقائياً)
    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewApplicationType())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateApplicationType();
        }
        return false;
    }

    private bool _AddNewApplicationType()
    {
        this.ApplicationTypeID = clsApplicationTypesData.AddNewApplicationType(this.Description, this.ApplicationFees);
        return (this.ApplicationTypeID != -1);
    }

    private bool _UpdateApplicationType()
    {
        return clsApplicationTypesData.UpdateApplicationType(this.ApplicationTypeID, this.Description, this.ApplicationFees);
    }

    public static DataTable GetAllApplicationTypes()
    {
        return clsApplicationTypesData.GetAllApplicationTypes();
    }

    public static bool Delete(int ApplicationTypeID)
    {
        return clsApplicationTypesData.DeleteApplicationType(ApplicationTypeID);
    }

    public static bool IsExist(int ApplicationTypeID)
    {
        return clsApplicationTypesData.IsApplicationTypeExist(ApplicationTypeID);
    }
}