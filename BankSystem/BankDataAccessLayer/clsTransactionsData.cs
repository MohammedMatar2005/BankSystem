using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsTransactionsData
{
    // 1. Get All Transactions
    public static DataTable GetAllTransactions()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetAllTransactions", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching all Transactions", ex);
            }
        }

        return dt;
    }

    // 2. Get Transaction Info By ID
    public static bool GetTransactionInfoByID(int TransactionID, ref int AccountID, ref int TransactionTypeID, ref decimal Amount, ref decimal BalanceBefore, ref decimal BalanceAfter, ref DateTime TransactionDate, ref int RelatedAccountID, ref string Description, ref int UserID)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetTransactionByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
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

    // 3. Check if Transaction Exists
    public static bool IsTransactionExist(int TransactionID)
    {
        bool exists = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_IsTransactionExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                exists = (result != null && result != DBNull.Value);
            }
            catch { exists = false; }
        }

        return exists;
    }

    // 4. Add New Transaction
    public static int AddNewTransaction(int AccountID, int TransactionTypeID, decimal Amount, decimal BalanceBefore, decimal BalanceAfter, DateTime TransactionDate, int RelatedAccountID, string Description, int UserID)
    {
        int newID = -1;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_AddNewTransaction", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

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

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_UpdateTransaction", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

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

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch { }
        }

        return rowsAffected > 0;
    }

    // 6. Delete Transaction
    public static bool DeleteTransaction(int TransactionID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_DeleteTransaction", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch { }
        }

        return rowsAffected > 0;
    }
}
