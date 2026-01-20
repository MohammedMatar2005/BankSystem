
using System;
using System.Data;
using Bank_DataAccess;

public class clsTransaction
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int TransactionID { get; set; }
    public int AccountID { get; set; }
    public int TransactionTypeID { get; set; }
    public decimal Amount { get; set; }
    public decimal BalanceBefore { get; set; }
    public decimal BalanceAfter { get; set; }
    public DateTime TransactionDate { get; set; }
    public int RelatedAccountID { get; set; }
    public string Description { get; set; }
    public int UserID { get; set; }


    public clsTransaction()
    {
        this.TransactionID = -1;
        this.AccountID = -1;
        this.TransactionTypeID = -1;
        this.Amount = 0;
        this.BalanceBefore = 0;
        this.BalanceAfter = 0;
        this.TransactionDate = DateTime.Now;
        this.RelatedAccountID = -1;
        this.Description = "";
        this.UserID = -1;
        Mode = enMode.AddNew;
    }

    private clsTransaction(int TransactionID, int AccountID, int TransactionTypeID, decimal Amount, decimal BalanceBefore, decimal BalanceAfter, DateTime TransactionDate, int RelatedAccountID, string Description, int UserID)
    {
        this.TransactionID = TransactionID;
        this.AccountID = AccountID;
        this.TransactionTypeID = TransactionTypeID;
        this.Amount = Amount;
        this.BalanceBefore = BalanceBefore;
        this.BalanceAfter = BalanceAfter;
        this.TransactionDate = TransactionDate;
        this.RelatedAccountID = RelatedAccountID;
        this.Description = Description;
        this.UserID = UserID;

        Mode = enMode.Update;
    }

    public static clsTransaction Find(int TransactionID)
    {
        int AccountID = -1;
        int TransactionTypeID = -1;
        decimal Amount = 0;
        decimal BalanceBefore = 0;
        decimal BalanceAfter = 0;
        DateTime TransactionDate = DateTime.Now;
        int RelatedAccountID = -1;
        string Description = "";
        int UserID = -1;

        bool isFound = clsTransactionsData.GetTransactionInfoByID(TransactionID, ref AccountID, ref TransactionTypeID, ref Amount, ref BalanceBefore, ref BalanceAfter, ref TransactionDate, ref RelatedAccountID, ref Description, ref UserID);

        if (isFound)
            return new clsTransaction(TransactionID, AccountID, TransactionTypeID, Amount, BalanceBefore, BalanceAfter, TransactionDate, RelatedAccountID, Description, UserID);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewTransaction())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateTransaction();
        }
        return false;
    }

    private bool _AddNewTransaction()
    {
        this.TransactionID = clsTransactionsData.AddNewTransaction(this.AccountID, this.TransactionTypeID, this.Amount, this.BalanceBefore, this.BalanceAfter, this.TransactionDate, this.RelatedAccountID, this.Description, this.UserID);
        return (this.TransactionID != -1);
    }

    private bool _UpdateTransaction()
    {
        return clsTransactionsData.UpdateTransaction(this.TransactionID, this.AccountID, this.TransactionTypeID, this.Amount, this.BalanceBefore, this.BalanceAfter, this.TransactionDate, this.RelatedAccountID, this.Description, this.UserID);
    }

    public static DataTable GetAllTransactions()
    {
        return clsTransactionsData.GetAllTransactions();
    }

    public static bool Delete(int TransactionID)
    {
        return clsTransactionsData.DeleteTransaction(TransactionID);
    }

    public static bool IsExist(int TransactionID)
    {
        return clsTransactionsData.IsTransactionExist(TransactionID);
    }
}