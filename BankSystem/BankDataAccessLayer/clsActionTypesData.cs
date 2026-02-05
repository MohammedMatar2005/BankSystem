
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsActionTypesData
{
  
  


    // 1. Get All ActionTypes (Returns DataTable)
    public static DataTable GetAllActionTypes()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM ActionTypes";
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
                catch (Exception ex) { throw new Exception("Error fetching all ActionTypes", ex); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID (Find)
    public static bool GetActionTypeInfoByID(int ActionTypeID, ref string Description)
    {
        bool isFound = false;
        const string query = "SELECT * FROM ActionTypes WHERE ActionTypeID = @ActionTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        Description = (string)reader["Description"];

                    }
                }
            }
            catch { isFound = false; }
        }
        return isFound;
    }

    // 3. Is ActionType Exist
    public static bool IsActionTypeExist(int ActionTypeID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM ActionTypes WHERE ActionTypeID = @ActionTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);
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

    // 4. Add New ActionType
    public static int AddNewActionType(string Description)
    {
        int newID = -1;
        const string query = @"INSERT INTO ActionTypes (Description) 
                               VALUES (@Description); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Description", Description);

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

    // 5. Update ActionType
    public static bool UpdateActionType(int ActionTypeID, string Description)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE ActionTypes SET Description = @Description WHERE ActionTypeID = @ActionTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);
            command.Parameters.AddWithValue("@Description", Description);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete ActionType
    public static bool DeleteActionType(int ActionTypeID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM ActionTypes WHERE ActionTypeID = @ActionTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }
}