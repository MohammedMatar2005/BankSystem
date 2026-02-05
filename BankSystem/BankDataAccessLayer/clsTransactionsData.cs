
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsTransactionsData
{
  

    // 1. Get All Transactions (Returns DataTable)
    public static DataTable GetAllTransactions()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM Transactions";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) dt.Load(reader);
                    }
                }
                catch (Exception ex) { throw new Exception("Error fetching all Transactions", ex); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID (Find)
    public static bool GetTransactionInfoByID(int TransactionID, ref int AccountID, ref int TransactionTypeID, ref decimal Amount, ref decimal BalanceBefore, ref decimal BalanceAfter, ref DateTime TransactionDate, ref int RelatedAccountID, ref string Description, ref int UserID)
    {
        bool isFound = false;
        const string query = "SELECT * FROM Transactions WHERE TransactionID = @TransactionID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        AccountID = (int)reader["AccountID"];
                        TransactionTypeID = (int)reader["TransactionTypeID"];
                        Amount = (decimal)reader["Amount"];
                        BalanceBefore = (decimal)reader["BalanceBefore"];
                        BalanceAfter = (decimal)reader["BalanceAfter"];
                        TransactionDate = (DateTime)reader["TransactionDate"];
                        RelatedAccountID = (int)reader["RelatedAccountID"];
                        Description = (string)reader["Description"];
                        UserID = (int)reader["UserID"];

                    }
                }
            }
            catch { isFound = false; }
        }
        return isFound;
    }

    // 3. Is Transaction Exist
    public static bool IsTransactionExist(int TransactionID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM Transactions WHERE TransactionID = @TransactionID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isFound = (result != null);
            }
            catch { isFound = false; }
        }
        return isFound;
    }

    // 4. Add New Transaction
    public static int AddNewTransaction(int AccountID, int TransactionTypeID, decimal Amount, decimal BalanceBefore, decimal BalanceAfter, DateTime TransactionDate, int RelatedAccountID, string Description, int UserID)
    {
        int newID = -1;
        const string query = @"INSERT INTO Transactions (AccountID, TransactionTypeID, Amount, BalanceBefore, BalanceAfter, TransactionDate, RelatedAccountID, Description, UserID) 
                               VALUES (@AccountID, @TransactionTypeID, @Amount, @BalanceBefore, @BalanceAfter, @TransactionDate, @RelatedAccountID, @Description, @UserID); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@BalanceBefore", BalanceBefore);
            command.Parameters.AddWithValue("@BalanceAfter", BalanceAfter);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            command.Parameters.AddWithValue("@RelatedAccountID", RelatedAccountID);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    newID = insertedID;
            }
            catch { }
        }
        return newID;
    }

    // 5. Update Transaction
    public static bool UpdateTransaction(int TransactionID, int AccountID, int TransactionTypeID, decimal Amount, decimal BalanceBefore, decimal BalanceAfter, DateTime TransactionDate, int RelatedAccountID, string Description, int UserID)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE Transactions SET AccountID = @AccountID, TransactionTypeID = @TransactionTypeID, Amount = @Amount, BalanceBefore = @BalanceBefore, BalanceAfter = @BalanceAfter, TransactionDate = @TransactionDate, RelatedAccountID = @RelatedAccountID, Description = @Description, UserID = @UserID WHERE TransactionID = @TransactionID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@BalanceBefore", BalanceBefore);
            command.Parameters.AddWithValue("@BalanceAfter", BalanceAfter);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            command.Parameters.AddWithValue("@RelatedAccountID", RelatedAccountID);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@UserID", UserID);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete Transaction
    public static bool DeleteTransaction(int TransactionID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM Transactions WHERE TransactionID = @TransactionID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }
}