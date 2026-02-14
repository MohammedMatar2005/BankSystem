using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsApplicationStatusesData
{
    // 1. Get All
    public static DataTable GetAllApplicationStatuses()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetAllApplicationStatuses", connection))
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
                throw new Exception("Error fetching all ApplicationStatuses", ex);
            }
        }

        return dt;
    }

    // 2. Get By ID
    public static bool GetApplicationStatusInfoByID(
        int ApplicationStatusID,
        ref string Description)
    {
        bool isFound = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetApplicationStatusByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        Description = reader["Description"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error finding ApplicationStatus", ex);
            }
        }

        return isFound;
    }

    // 3. Is Exist
    public static bool IsApplicationStatusExist(int ApplicationStatusID)
    {
        bool exists = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_IsApplicationStatusExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    exists = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking ApplicationStatus existence", ex);
            }
        }

        return exists;
    }

    // 4. Add New
    public static int AddNewApplicationStatus(string Description)
    {
        int newID = -1;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_AddNewApplicationStatus", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Description", Description);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    newID = insertedID;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding ApplicationStatus", ex);
            }
        }

        return newID;
    }

    // 5. Update
    public static bool UpdateApplicationStatus(
        int ApplicationStatusID,
        string Description)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_UpdateApplicationStatus", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@Description", Description);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating ApplicationStatus", ex);
            }
        }

        return (rowsAffected > 0);
    }

    // 6. Delete
    public static bool DeleteApplicationStatus(int ApplicationStatusID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_DeleteApplicationStatus", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting ApplicationStatus", ex);
            }
        }

        return (rowsAffected > 0);
    }
}
