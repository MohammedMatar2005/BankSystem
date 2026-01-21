
using Bank_DataAccess;
using BankDataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsClientsData
{


    // 1. Get All Clients (Returns DataTable)
    public static DataTable GetAllClients()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM Clients";
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
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID (Find)
    public static bool GetClientInfoByID(int ClientID, ref int PersonID, ref DateTime ClientRegistrationDate, ref int CreatedByUserID)
    {
        bool isFound = false;
        const string query = "SELECT * FROM Clients WHERE ClientID = @ClientID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
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
            catch { isFound = false; }
        }
        return isFound;
    }

    // 3. Is Client Exist
    public static bool IsClientExist(int ClientID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM Clients WHERE ClientID = @ClientID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ClientID", ClientID);
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

    // 4. Add New Client
    public static int AddNewClient(int PersonID, DateTime ClientRegistrationDate, int CreatedByUserID)
    {
        int newID = -1;
        const string query = @"INSERT INTO Clients (PersonID, ClientRegistrationDate, CreatedByUserID) 
                               VALUES (@PersonID, @ClientRegistrationDate, @CreatedByUserID); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
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
            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
        }
        return newID;
    }

    // 5. Update Client
    public static bool UpdateClient(int ClientID, int PersonID, DateTime ClientRegistrationDate, int CreatedByUserID)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE Clients SET PersonID = @PersonID, ClientRegistrationDate = @ClientRegistrationDate, CreatedByUserID = @CreatedByUserID WHERE ClientID = @ClientID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ClientRegistrationDate", ClientRegistrationDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete Client
    public static bool DeleteClient(int ClientID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM Clients WHERE ClientID = @ClientID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ClientID", ClientID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch(Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
        }
        return (rowsAffected > 0);
    }
}