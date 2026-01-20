
using System;
using System.Data;
using BankDataAccessLayer;

public class clsActivityLogs
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int LogID { get; set; }
    public int UserID { get; set; }
    public int ActionTypeID { get; set; }
    public DateTime LogDate { get; set; }
    public string Description { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }


    // Constructor للوضع الافتراضي (إضافة جديد)
    public clsActivityLogs()
    {
        this.LogID = -1;
        this.UserID = -1;
        this.ActionTypeID = -1;
        this.LogDate = DateTime.Now;
        this.Description = "";
        this.OldValue = "";
        this.NewValue = "";
        Mode = enMode.AddNew;
    }

    private clsActivityLogs(int LogID, int UserID, int ActionTypeID, DateTime LogDate, string Description, string OldValue, string NewValue)
    {
        this.LogID = LogID;
        this.UserID = UserID;
        this.ActionTypeID = ActionTypeID;
        this.LogDate = LogDate;
        this.Description = Description;
        this.OldValue = OldValue;
        this.NewValue = NewValue;

        Mode = enMode.Update;
    }

    public static clsActivityLogs Find(int LogID)
    {
        int UserID = -1;
        int ActionTypeID = -1;
        DateTime LogDate = DateTime.Now;
        string Description = "";
        string OldValue = "";
        string NewValue = "";

        bool isFound = clsActivityLogsData.GetActivityLogInfoByID(LogID, ref UserID, ref ActionTypeID, ref LogDate, ref Description, ref OldValue, ref NewValue);

        if (isFound)
            return new clsActivityLogs(LogID, UserID, ActionTypeID, LogDate, Description, OldValue, NewValue);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewActivityLog())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateActivityLog();
        }
        return false;
    }

    private bool _AddNewActivityLog()
    {
        this.LogID = clsActivityLogsData.AddNewActivityLog(this.UserID, this.ActionTypeID, this.LogDate, this.Description, this.OldValue, this.NewValue);
        return (this.LogID != -1);
    }

    private bool _UpdateActivityLog()
    {
        return clsActivityLogsData.UpdateActivityLog(this.LogID, this.UserID, this.ActionTypeID, this.LogDate, this.Description, this.OldValue, this.NewValue);
    }

    public static DataTable GetAllActivityLogs()
    {
        return clsActivityLogsData.GetAllActivityLogs();
    }

    public static bool Delete(int LogID)
    {
        return clsActivityLogsData.DeleteActivityLog(LogID);
    }

    public static bool IsExist(int LogID)
    {
        return clsActivityLogsData.IsActivityLogExist(LogID);
    }
}