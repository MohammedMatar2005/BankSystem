
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsRolesData
{
    // --- Properties ---
    public int RoleID { get; set; }
    public string Description { get; set; }


    // 1. Get All Roles (Returns DataTable)
    public static DataTable GetAllRoles()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM Roles";
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
                catch (Exception ex) { throw new Exception("Error fetching all Roles", ex); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID (Find)
    public static bool GetRoleInfoByID(int RoleID, ref string Description)
    {
        bool isFound = false;
        const string query = "SELECT * FROM Roles WHERE RoleID = @RoleID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@RoleID", RoleID);
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
            catch { isFound = false; }
        }
        return isFound;
    }

    // 3. Is Role Exist
    public static bool IsRoleExist(int RoleID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM Roles WHERE RoleID = @RoleID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@RoleID", RoleID);
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

    // 4. Add New Role
    public static int AddNewRole(string Description)
    {
        int newID = -1;
        const string query = @"INSERT INTO Roles (Description) 
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
            catch { }
        }
        return newID;
    }

    // 5. Update Role
    public static bool UpdateRole(int RoleID, string Description)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE Roles SET Description = @Description WHERE RoleID = @RoleID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@Description", Description);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete Role
    public static bool DeleteRole(int RoleID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM Roles WHERE RoleID = @RoleID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@RoleID", RoleID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }
}