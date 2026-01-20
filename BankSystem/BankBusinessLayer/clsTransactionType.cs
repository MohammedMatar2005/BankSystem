
using System;
using System.Data;
using Bank_DataAccess;
public class clsTransactionType
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int TransactionTypeID { get; set; }
    public string TransactionName { get; set; }
    public string Description { get; set; }
    public int Effect { get; set; }
    public bool IsActive { get; set; }


    public clsTransactionType()
    {
        this.TransactionTypeID = -1;
        this.TransactionName = "";
        this.Description = "";
        this.Effect = 0;
        this.IsActive = true;
        Mode = enMode.AddNew;
    }

    private clsTransactionType(int TransactionTypeID, string TransactionName, string Description, int Effect, bool IsActive)
    {
        this.TransactionTypeID = TransactionTypeID;
        this.TransactionName = TransactionName;
        this.Description = Description;
        this.Effect = Effect;
        this.IsActive = IsActive;

        Mode = enMode.Update;
    }

    public static clsTransactionType Find(int TransactionTypeID)
    {
        string TransactionName = "";
        string Description = "";
        int Effect = -1;
        bool IsActive = false;

        bool isFound = clsTransactionTypesData.GetTransactionTypeInfoByID(TransactionTypeID, ref TransactionName, ref Description, ref Effect, ref IsActive);

        if (isFound)
            return new clsTransactionType(TransactionTypeID, TransactionName, Description, Effect, IsActive);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewTransactionType())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateTransactionType();
        }
        return false;
    }

    private bool _AddNewTransactionType()
    {
        this.TransactionTypeID = clsTransactionTypesData.AddNewTransactionType(this.TransactionName, this.Description, this.Effect, this.IsActive);
        return (this.TransactionTypeID != -1);
    }

    private bool _UpdateTransactionType()
    {
        return clsTransactionTypesData.UpdateTransactionType(this.TransactionTypeID, this.TransactionName, this.Description, this.Effect, this.IsActive);
    }

    public static DataTable GetAllTransactionTypes()
    {
        return clsTransactionTypesData.GetAllTransactionTypes();
    }

    public static bool Delete(int TransactionTypeID)
    {
        return clsTransactionTypesData.DeleteTransactionType(TransactionTypeID);
    }

    public static bool IsExist(int TransactionTypeID)
    {
        return clsTransactionTypesData.IsTransactionTypeExist(TransactionTypeID);
    }
}