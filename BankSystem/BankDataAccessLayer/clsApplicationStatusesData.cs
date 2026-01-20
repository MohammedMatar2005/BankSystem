
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsApplicationStatusesData
{
    


    public static DataTable GetAllApplicationStatuses()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM ApplicationStatuses";
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
                catch (Exception ex)
                {
                    throw new Exception("Error fetching all ApplicationStatusess", ex);
                }
            }
        }
        return dt;
    }

    public static bool GetApplicationStatusesInfoByApplicationStatusID(int ApplicationStatusID, ref string Description)
    {
        bool isFound = false;
        const string query = "SELECT * FROM ApplicationStatuses WHERE ApplicationStatusID = @ApplicationStatusID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
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
            catch (Exception ex) { throw new Exception("Error fetching ApplicationStatuses info", ex); }
        }
        return isFound;
    }

    public static int AddNewApplicationStatuses(string Description)
    {
        int newID = -1;
        const string query = @"INSERT INTO ApplicationStatuses (Description) 
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
            catch (Exception ex) { throw new Exception("Error adding ApplicationStatuses", ex); }
        }
        return newID;
    }

    public static bool UpdateApplicationStatuses(int ApplicationStatusID, string Description)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE ApplicationStatuses 
                               SET Description = @Description 
                               WHERE ApplicationStatusID = @ApplicationStatusID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@Description", Description);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error updating ApplicationStatuses", ex); }
        }
        return (rowsAffected > 0);
    }

    public static bool DeleteApplicationStatuses(int ApplicationStatusID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM ApplicationStatuses WHERE ApplicationStatusID = @ApplicationStatusID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error deleting ApplicationStatuses", ex); }
        }
        return (rowsAffected > 0);
    }
}