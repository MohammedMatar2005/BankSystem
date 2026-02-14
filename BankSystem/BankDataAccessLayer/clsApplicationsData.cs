using System;
using System.Data;
using System.Data.SqlClient;
using Bank_DataAccess;
using BankDataAccessLayer;

public class clsApplicationsData
{
    // 1. Get All Applications
    public static DataTable GetAllApplications()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetAllApplications", connection))
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

    // 2. Get Info By ID
    public static bool GetApplicationInfoByID(
        int ApplicationID,
        ref int ApplicationTypeID,
        ref int PersonID,
        ref DateTime ApplicationDateTime,
        ref int ApplicationStatusID,
        ref DateTime LastStatusDate,
        ref int CreatedByUserID,
        ref decimal PaidFees)
    {
        bool isFound = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetApplicationByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;

                        ApplicationTypeID = (int)reader["ApplicationTypeID"];
                        PersonID = (int)reader["PersonID"];
                        ApplicationDateTime = (DateTime)reader["DateTime"];
                        ApplicationStatusID = (int)reader["ApplicationStatusID"];
                        LastStatusDate = (DateTime)reader["LastStatusDate"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];
                        PaidFees = (decimal)reader["PaidFees"];
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return isFound;
    }

    // 3. Is Application Exist
    public static bool IsApplicationExist(int ApplicationID)
    {
        bool exists = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_IsApplicationExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

    // 4. Add New Application
    public static int AddNewApplication(
        int ApplicationTypeID,
        int PersonID,
        DateTime ApplicationDateTime,
        int ApplicationStatusID,
        DateTime LastStatusDate,
        int CreatedByUserID,
        decimal PaidFees)
    {
        int newID = -1;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_AddApplication", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DateTime", ApplicationDateTime);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);

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

    // 5. Update Application
    public static bool UpdateApplication(
        int ApplicationID,
        int ApplicationTypeID,
        int PersonID,
        DateTime ApplicationDateTime,
        int ApplicationStatusID,
        DateTime LastStatusDate,
        int CreatedByUserID,
        decimal PaidFees)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_UpdateApplication", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DateTime", ApplicationDateTime);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);

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

    // 6. Delete Application
    public static bool DeleteApplication(int ApplicationID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_DeleteApplication", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
