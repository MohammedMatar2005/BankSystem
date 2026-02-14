
using System;
using System.Data;
using Bank_DataAccess; 

public class clsApplicationStatus
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int ApplicationStatusID { get; set; }
    public string Description { get; set; }


    public clsApplicationStatus()
    {
        this.ApplicationStatusID = -1;
        this.Description = "";
        Mode = enMode.AddNew;
    }

    private clsApplicationStatus(int ApplicationStatusID, string Description)
    {
        this.ApplicationStatusID = ApplicationStatusID;
        this.Description = Description;

        Mode = enMode.Update;
    }

    
    public static clsApplicationStatus Find(int ApplicationStatusID)
    {
        string Description = "";

        bool isFound = clsApplicationStatusesData.GetApplicationStatusInfoByID(ApplicationStatusID, ref Description);

        if (isFound)
            return new clsApplicationStatus(ApplicationStatusID, Description);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewApplicationStatuses())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateApplicationStatuses();
        }
        return false;
    }

    private bool _AddNewApplicationStatuses()
    {
        this.ApplicationStatusID = clsApplicationStatusesData.AddNewApplicationStatus(this.Description);
        return (this.ApplicationStatusID != -1);
    }

    private bool _UpdateApplicationStatuses()
    {
        return clsApplicationStatusesData.UpdateApplicationStatus(this.ApplicationStatusID, this.Description);
    }

    public static DataTable GetAllApplicationStatuses()
    {
        return clsApplicationStatusesData.GetAllApplicationStatuses();
    }

    public static bool Delete(int ApplicationStatusID)
    {
        return clsApplicationStatusesData.DeleteApplicationStatus(ApplicationStatusID);
    }

}