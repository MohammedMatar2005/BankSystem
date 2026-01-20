
using System;
using System.Data;
using BankDataAccessLayer;
public class clsAccount
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int AccountID { get; set; }
    public int ClientID { get; set; }
    public string AccountNumber { get; set; }
    public string Password { get; set; }
    public decimal Balance { get; set; }


    public clsAccount()
    {
        this.AccountID = -1;
        this.ClientID = -1;
        this.AccountNumber = "";
        this.Password = "";
        this.Balance = 0;
        Mode = enMode.AddNew;
    }

    private clsAccount(int AccountID, int ClientID, string AccountNumber, string Password, decimal Balance)
    {
        this.AccountID = AccountID;
        this.ClientID = ClientID;
        this.AccountNumber = AccountNumber;
        this.Password = Password;
        this.Balance = Balance;

        Mode = enMode.Update;
    }

    public static clsAccount Find(int AccountID)
    {
        int ClientID = -1;
        string AccountNumber = "";
        string Password = "";
        decimal Balance = 0;

        bool isFound = clsAccountsData.GetAccountInfoByID(AccountID, ref ClientID, ref AccountNumber, ref Password, ref Balance);

        if (isFound)
            return new clsAccount(AccountID, ClientID, AccountNumber, Password, Balance);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewAccount())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateAccount();
        }
        return false;
    }

    private bool _AddNewAccount()
    {
        this.AccountID = clsAccountsData.AddNewAccount(this.ClientID, this.AccountNumber, this.Password, this.Balance);
        return (this.AccountID != -1);
    }

    private bool _UpdateAccount()
    {
        return clsAccountsData.UpdateAccount(this.AccountID, this.ClientID, this.AccountNumber, this.Password, this.Balance);
    }

    public static DataTable GetAllAccounts()
    {
        return clsAccountsData.GetAllAccounts();
    }

    public static bool Delete(int AccountID)
    {
        return clsAccountsData.DeleteAccount(AccountID);
    }

    public static bool IsExist(int AccountID)
    {
        return clsAccountsData.IsAccountExist(AccountID);
    }
}