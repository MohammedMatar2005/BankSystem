using System;
using System.Data;
using System.Data.SqlClient;
using Bank_DataAccess;
using BankDataAccessLayer;

public class clsApplicationTypesData
{
    // 1. Get All
    public static DataTable GetAllApplicationTypes()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetAllApplicationTypes", connection))
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
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return dt;
    }

    // 2. Get By ID
    public static bool GetApplicationTypeInfoByID(
        int ApplicationTypeID,
        ref string Description,
        ref decimal ApplicationFees)
    {
        bool isFound = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetApplicationTypeByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        Description = reader["Description"].ToString();
                        ApplicationFees = (decimal)reader["ApplicationFees"];
                    }
                }
            }
            catch (Exception ex)
            {
                
                isFound = false;
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return isFound;
    }

    // 3. Is Exist
    public static bool IsApplicationTypeExist(int ApplicationTypeID)
    {
        bool exists = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_IsApplicationTypeExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    exists = true;
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return exists;
    }

    // 4. Add New
    public static int AddNewApplicationType(string Description, decimal ApplicationFees)
    {
        int newID = -1;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_AddApplicationType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    newID = insertedID;
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return newID;
    }

    // 5. Update
    public static bool UpdateApplicationType(
        int ApplicationTypeID,
        string Description,
         decimal ApplicationFees)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_UpdateApplicationType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return (rowsAffected > 0);
    }

    // 6. Delete
    public static bool DeleteApplicationType(int ApplicationTypeID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_DeleteApplicationType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return (rowsAffected > 0);
    }
}
