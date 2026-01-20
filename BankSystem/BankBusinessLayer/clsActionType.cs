
using System;
using System.Data;
using BankDataAccessLayer;

public class clsActionTypes
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int ActionTypeID { get; set; }
    public string Description { get; set; }


 
    public clsActionTypes()
    {
        this.ActionTypeID = -1;
        this.Description = "";

        Mode = enMode.AddNew;
    }

 
    private clsActionTypes(int ActionTypeID, string Description)
    {
        this.ActionTypeID = ActionTypeID;
        this.Description = Description;

        Mode = enMode.Update;
    }

    
    public static clsActionTypes Find(int ActionTypeID)
    {
        string Description = "";

        bool isFound = clsActionTypesData.GetActionTypeInfoByID(ActionTypeID, ref Description);

        if (isFound)
            return new clsActionTypes(ActionTypeID, Description);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewActionType())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateActionType();
        }
        return false;
    }

    private bool _AddNewActionType()
    {
        this.ActionTypeID = clsActionTypesData.AddNewActionType(this.Description);
        return (this.ActionTypeID != -1);
    }

    private bool _UpdateActionType()
    {
        return clsActionTypesData.UpdateActionType(this.ActionTypeID, this.Description);
    }

    public static DataTable GetAllActionTypes()
    {
        return clsActionTypesData.GetAllActionTypes();
    }

    public static bool Delete(int ActionTypeID)
    {
        return clsActionTypesData.DeleteActionType(ActionTypeID);
    }

    public static bool IsExist(int ActionTypeID)
    {
        return clsActionTypesData.IsActionTypeExist(ActionTypeID);
    }
}