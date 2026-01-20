
using System;
using System.Data;
using BankDataAccessLayer;

public class clsApplication
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int ApplicationID { get; set; }
    public int ApplicationTypeID { get; set; }
    public int PersonID { get; set; }
    public DateTime DateTime { get; set; }
    public int ApplicationStatusID { get; set; }
    public DateTime LastStatusDate { get; set; }
    public int CreatedByUserID { get; set; }


    public clsApplication()
    {
        this.ApplicationID = -1;
        this.ApplicationTypeID = -1;
        this.PersonID = -1;
        this.ApplicationStatusID = -1;
        this.DateTime = DateTime.Now;
        this.LastStatusDate = DateTime.Now;
        this.CreatedByUserID = -1;
        Mode = enMode.AddNew;
    }

    private clsApplication(int ApplicationID, int ApplicationTypeID, int PersonID, DateTime DateTime, int ApplicationStatusID, DateTime LastStatusDate, int CreatedByUserID)
    {
        this.ApplicationID = ApplicationID;
        this.ApplicationTypeID = ApplicationTypeID;
        this.PersonID = PersonID;
        this.DateTime = DateTime;
        this.ApplicationStatusID = ApplicationStatusID;
        this.LastStatusDate = LastStatusDate;
        this.CreatedByUserID = CreatedByUserID;

        Mode = enMode.Update;
    }

    public static clsApplication Find(int ApplicationID)
    {
        int ApplicationTypeID = -1;
        int PersonID = -1;
        DateTime DateTime = DateTime.Now;
        int ApplicationStatusID = -1;
        DateTime LastStatusDate = DateTime.Now;
        int CreatedByUserID = -1;

        bool isFound = clsApplicationsData.GetApplicationInfoByID(ApplicationID, ref ApplicationTypeID, ref PersonID, ref DateTime, ref ApplicationStatusID, ref LastStatusDate, ref CreatedByUserID);

        if (isFound)
            return new clsApplication(ApplicationID, ApplicationTypeID, PersonID, DateTime, ApplicationStatusID, LastStatusDate, CreatedByUserID);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewApplication())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateApplication();
        }
        return false;
    }

    private bool _AddNewApplication()
    {
        this.ApplicationID = clsApplicationsData.AddNewApplication(this.ApplicationTypeID, this.PersonID, this.DateTime, this.ApplicationStatusID, this.LastStatusDate, this.CreatedByUserID);
        return (this.ApplicationID != -1);
    }

    private bool _UpdateApplication()
    {
        return clsApplicationsData.UpdateApplication(this.ApplicationID, this.ApplicationTypeID, this.PersonID, this.DateTime, this.ApplicationStatusID, this.LastStatusDate, this.CreatedByUserID);
    }

    public static DataTable GetAllApplications()
    {
        return clsApplicationsData.GetAllApplications();
    }

    public static bool Delete(int ApplicationID)
    {
        return clsApplicationsData.DeleteApplication(ApplicationID);
    }

    public static bool IsExist(int ApplicationID)
    {
        return clsApplicationsData.IsApplicationExist(ApplicationID);
    }
}