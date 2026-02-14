using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsTransactionTypesData
{
    // 1. Get All TransactionTypes
    public static DataTable GetAllTransactionTypes()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetAllTransactionTypes", connection))
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
                throw new Exception("Error fetching all TransactionTypes", ex);
            }
        }

        return dt;
    }

    // 2. Get TransactionType Info By ID
    public static bool GetTransactionTypeInfoByID(int TransactionTypeID, ref string TransactionName, ref string Description, ref int Effect, ref bool IsActive)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetTransactionTypeByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        TransactionName = (string)reader["TransactionName"];
                        Description = (string)reader["Description"];
                        Effect = (int)reader["Effect"];
                        IsActive = (bool)reader["IsActive"];
                    }
                }
            }
            catch { isFound = false; }
        }

        return isFound;
    }

    // 3. Check if TransactionType Exists
    public static bool IsTransactionTypeExist(int TransactionTypeID)
    {
        bool exists = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_IsTransactionTypeExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);

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

    // 4. Add New TransactionType
    public static int AddNewTransactionType(string TransactionName, string Description, int Effect, bool IsActive)
    {
        int newID = -1;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_AddNewTransactionType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@TransactionName", TransactionName);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Effect", Effect);
            command.Parameters.AddWithValue("@IsActive", IsActive);

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

    // 5. Update TransactionType
    public static bool UpdateTransactionType(int TransactionTypeID, string TransactionName, string Description, int Effect, bool IsActive)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_UpdateTransactionType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            command.Parameters.AddWithValue("@TransactionName", TransactionName);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Effect", Effect);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch { }
        }

        return rowsAffected > 0;
    }

    // 6. Delete TransactionType
    public static bool DeleteTransactionType(int TransactionTypeID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_DeleteTransactionType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);

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
