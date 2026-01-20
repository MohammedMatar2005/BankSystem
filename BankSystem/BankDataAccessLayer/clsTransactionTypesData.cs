
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsTransactionTypesData
{
    // --- Properties ---
    public byte TransactionTypeID { get; set; }
    public string TransactionName { get; set; }
    public string Description { get; set; }
    public int Effect { get; set; }
    public bool IsActive { get; set; }


    // 1. Get All TransactionTypes (Returns DataTable)
    public static DataTable GetAllTransactionTypes()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM TransactionTypes";
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
                catch (Exception ex) { throw new Exception("Error fetching all TransactionTypes", ex); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID (Find)
    public static bool GetTransactionTypeInfoByID(int TransactionTypeID, ref string TransactionName, ref string Description, ref int Effect, ref bool IsActive)
    {
        bool isFound = false;
        const string query = "SELECT * FROM TransactionTypes WHERE TransactionTypeID = @TransactionTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
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

    // 3. Is TransactionType Exist
    public static bool IsTransactionTypeExist(int TransactionTypeID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM TransactionTypes WHERE TransactionTypeID = @TransactionTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
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

    // 4. Add New TransactionType
    public static int AddNewTransactionType(string TransactionName, string Description, int Effect, bool IsActive)
    {
        int newID = -1;
        const string query = @"INSERT INTO TransactionTypes (TransactionName, Description, Effect, IsActive) 
                               VALUES (@TransactionName, @Description, @Effect, @IsActive); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
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
        const string query = @"UPDATE TransactionTypes SET TransactionName = @TransactionName, Description = @Description, Effect = @Effect, IsActive = @IsActive WHERE TransactionTypeID = @TransactionTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            command.Parameters.AddWithValue("@TransactionName", TransactionName);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Effect", Effect);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete TransactionType
    public static bool DeleteTransactionType(int TransactionTypeID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM TransactionTypes WHERE TransactionTypeID = @TransactionTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }
}