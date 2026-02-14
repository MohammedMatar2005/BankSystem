using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsActivityLogsData
{
    // 1. Get All ActivityLogs
    public static DataTable GetAllActivityLogs()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetAllActivityLogs", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching all ActivityLogs", ex);
            }
        }

        return dt;
    }

    // 2. Get Info By ID
    public static bool GetActivityLogInfoByID(
        int LogID,
        ref int UserID,
        ref int ActionTypeID,
        ref DateTime LogDate,
        ref string Description,
        ref string OldValue,
        ref string NewValue)
    {
        bool isFound = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetActivityLogByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
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
                        Description = reader["Description"].ToString();
                        OldValue = reader["OldValue"].ToString();
                        NewValue = reader["NewValue"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error finding ActivityLog", ex);
            }
        }

        return isFound;
    }

    // 3. Is ActivityLog Exist
    public static bool IsActivityLogExist(int LogID)
    {
        bool exists = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_IsActivityLogExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@LogID", LogID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    exists = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking ActivityLog existence", ex);
            }
        }

        return exists;
    }

    // 4. Add New ActivityLog
    public static int AddNewActivityLog(
        int UserID,
        int ActionTypeID,
        DateTime LogDate,
        string Description,
        string OldValue,
        string NewValue)
    {
        int newID = -1;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_AddNewActivityLog", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

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
            catch (Exception ex)
            {
                throw new Exception("Error adding ActivityLog", ex);
            }
        }

        return newID;
    }

    // 5. Update ActivityLog
    public static bool UpdateActivityLog(
        int LogID,
        int UserID,
        int ActionTypeID,
        DateTime LogDate,
        string Description,
        string OldValue,
        string NewValue)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_UpdateActivityLog", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@LogID", LogID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);
            command.Parameters.AddWithValue("@LogDate", LogDate);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@OldValue", OldValue);
            command.Parameters.AddWithValue("@NewValue", NewValue);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating ActivityLog", ex);
            }
        }

        return (rowsAffected > 0);
    }

    // 6. Delete ActivityLog
    public static bool DeleteActivityLog(int LogID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_DeleteActivityLog", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@LogID", LogID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting ActivityLog", ex);
            }
        }

        return (rowsAffected > 0);
    }
}
