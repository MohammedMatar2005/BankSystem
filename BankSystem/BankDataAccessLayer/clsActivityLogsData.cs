
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsActivityLogsData
{



    // 1. Get All ActivityLogs (Returns DataTable)
    public static DataTable GetAllActivityLogs()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM ActivityLogs";
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
                catch (Exception ex) { throw new Exception("Error fetching all ActivityLogs", ex); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID (Find)
    public static bool GetActivityLogInfoByID(int LogID, ref int UserID, ref int ActionTypeID, ref DateTime LogDate, ref string Description, ref string OldValue, ref string NewValue)
    {
        bool isFound = false;
        const string query = "SELECT * FROM ActivityLogs WHERE LogID = @LogID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@LogID", LogID);
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        UserID = (int)reader["UserID"];
                        ActionTypeID = (int)reader["ActionTypeID"];
                        LogDate = (DateTime)reader["LogDate"];
                        Description = (string)reader["Description"];
                        OldValue = (string)reader["OldValue"];
                        NewValue = (string)reader["NewValue"];

                    }
                }
            }
            catch { isFound = false; }
        }
        return isFound;
    }

    // 3. Is ActivityLog Exist
    public static bool IsActivityLogExist(int LogID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM ActivityLogs WHERE LogID = @LogID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@LogID", LogID);
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

    // 4. Add New ActivityLog
    public static int AddNewActivityLog(int UserID, int ActionTypeID, DateTime LogDate, string Description, string OldValue, string NewValue)
    {
        int newID = -1;
        const string query = @"INSERT INTO ActivityLogs (UserID, ActionTypeID, LogDate, Description, OldValue, NewValue) 
                               VALUES (@UserID, @ActionTypeID, @LogDate, @Description, @OldValue, @NewValue); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);
            command.Parameters.AddWithValue("@LogDate", LogDate);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@OldValue", OldValue);
            command.Parameters.AddWithValue("@NewValue", NewValue);

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

    // 5. Update ActivityLog
    public static bool UpdateActivityLog(int LogID, int UserID, int ActionTypeID, DateTime LogDate, string Description, string OldValue, string NewValue)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE ActivityLogs SET UserID = @UserID, ActionTypeID = @ActionTypeID, LogDate = @LogDate, Description = @Description, OldValue = @OldValue, NewValue = @NewValue WHERE LogID = @LogID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@LogID", LogID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);
            command.Parameters.AddWithValue("@LogDate", LogDate);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@OldValue", OldValue);
            command.Parameters.AddWithValue("@NewValue", NewValue);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete ActivityLog
    public static bool DeleteActivityLog(int LogID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM ActivityLogs WHERE LogID = @LogID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@LogID", LogID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }
}