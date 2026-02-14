using Bank_DataAccess;
using BankDataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsClientsData
{
    // 1. Get All Clients
    public static DataTable GetAllClients()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetAllClients", connection))
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

    // 2. Get Client Info By ID
    public static bool GetClientInfoByID(int ClientID, ref int PersonID, ref DateTime ClientRegistrationDate, ref int CreatedByUserID)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetClientByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        PersonID = (int)reader["PersonID"];
                        ClientRegistrationDate = (DateTime)reader["ClientRegistrationDate"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
                isFound = false;
            }
        }

        return isFound;
    }

    // 3. Check if Client Exists
    public static bool IsClientExist(int ClientID)
    {
        bool exists = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_IsClientExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                exists = (result != null && result != DBNull.Value);
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
                exists = false;
            }
        }

        return exists;
    }

    // 4. Add New Client
    public static int AddNewClient(int PersonID, DateTime ClientRegistrationDate, int CreatedByUserID)
    {
        int newID = -1;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_AddNewClient", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ClientRegistrationDate", ClientRegistrationDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

    // 5. Update Client
    public static bool UpdateClient(int ClientID, int PersonID, DateTime ClientRegistrationDate, int CreatedByUserID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_UpdateClient", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ClientRegistrationDate", ClientRegistrationDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        return rowsAffected > 0;
    }

    // 6. Delete Client
    public static bool DeleteClient(int ClientID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_DeleteClient", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        return rowsAffected > 0;
    }
}
