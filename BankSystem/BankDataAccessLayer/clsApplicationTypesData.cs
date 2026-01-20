
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsApplicationTypesData
{
   
    public int ApplicationTypeID { get; set; }
    public string Description { get; set; }


   
    public static DataTable GetAllApplicationTypes()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM ApplicationTypes";
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
                    throw new Exception("Error fetching all ApplicationTypess", ex);
                }
            }
        }
        return dt;
    }

    public static bool GetApplicationTypesInfoByApplicationTypeID(int ApplicationTypeID, ref string Description)
    {
        bool isFound = false;
        const string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
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
            catch (Exception ex) { throw new Exception("Error fetching ApplicationTypes info", ex); }
        }
        return isFound;
    }

   
    public static int AddNewApplicationTypes(string Description)
    {
        int newID = -1;
        const string query = @"INSERT INTO ApplicationTypes (Description) 
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
            catch (Exception ex) { throw new Exception("Error adding ApplicationTypes", ex); }
        }
        return newID;
    }


    public static bool UpdateApplicationTypes(int ApplicationTypeID, string Description)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE ApplicationTypes 
                               SET Description = @Description 
                               WHERE ApplicationTypeID = @ApplicationTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@Description", Description);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error updating ApplicationTypes", ex); }
        }
        return (rowsAffected > 0);
    }

  
    public static bool DeleteApplicationTypes(int ApplicationTypeID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error deleting ApplicationTypes", ex); }
        }
        return (rowsAffected > 0);
    }

    public static bool IsApplicationTypeExist(int ApplicationTypeID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                // ≈–« ·„ Ìﬂ‰ «·‰« Ã null° ›Â–« Ì⁄‰Ì √‰ «·”Ã· „ÊÃÊœ
                isFound = (result != null);
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if ApplicationTypes exists", ex);
            }
        }
        return isFound;
    }


}