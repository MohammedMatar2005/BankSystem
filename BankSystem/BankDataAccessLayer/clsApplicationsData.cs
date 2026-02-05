
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsApplicationsData
{
 

    // 1. Get All Applications (Returns DataTable)
    public static DataTable GetAllApplications()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM Applications";
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
                catch (Exception ex) { throw new Exception("Error fetching all Applications", ex); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID (Find)
    public static bool GetApplicationInfoByID(int ApplicationID, ref int ApplicationTypeID, ref int PersonID, ref DateTime DateTime, ref int ApplicationStatusID, ref DateTime LastStatusDate, ref int CreatedByUserID)
    {
        bool isFound = false;
        const string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
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
                        DateTime = (DateTime)reader["DateTime"];
                        ApplicationStatusID = (int)reader["ApplicationStatusID"];
                        LastStatusDate = (DateTime)reader["LastStatusDate"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];

                    }
                }
            }
            catch { isFound = false; }
        }
        return isFound;
    }

    // 3. Is Application Exist
    public static bool IsApplicationExist(int ApplicationID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM Applications WHERE ApplicationID = @ApplicationID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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

    // 4. Add New Application
    public static int AddNewApplication(int ApplicationTypeID, int PersonID, DateTime DateTime, int ApplicationStatusID, DateTime LastStatusDate, int CreatedByUserID)
    {
        int newID = -1;
        const string query = @"INSERT INTO Applications (ApplicationTypeID, PersonID, DateTime, ApplicationStatusID, LastStatusDate, CreatedByUserID) 
                               VALUES (@ApplicationTypeID, @PersonID, @DateTime, @ApplicationStatusID, @LastStatusDate, @CreatedByUserID); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DateTime", DateTime);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

    // 5. Update Application
    public static bool UpdateApplication(int ApplicationID, int ApplicationTypeID, int PersonID, DateTime DateTime, int ApplicationStatusID, DateTime LastStatusDate, int CreatedByUserID)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE Applications SET ApplicationTypeID = @ApplicationTypeID, PersonID = @PersonID, DateTime = @DateTime, ApplicationStatusID = @ApplicationStatusID, LastStatusDate = @LastStatusDate, CreatedByUserID = @CreatedByUserID WHERE ApplicationID = @ApplicationID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DateTime", DateTime);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete Application
    public static bool DeleteApplication(int ApplicationID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }
}