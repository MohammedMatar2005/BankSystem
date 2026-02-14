using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsRolesData
{
    // 1. Get All Roles
    public static DataTable GetAllRoles()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetAllRoles", connection))
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
                throw new Exception("Error fetching all Roles", ex);
            }
        }

        return dt;
    }

    // 2. Get Role Info By ID
    public static bool GetRoleInfoByID(int RoleID, ref string Description)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetRoleByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
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
            catch
            {
                isFound = false;
            }
        }

        return isFound;
    }

    // 3. Check if Role Exists
    public static bool IsRoleExist(int RoleID)
    {
        bool exists = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_IsRoleExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RoleID", RoleID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                exists = (result != null && result != DBNull.Value);
            }
            catch
            {
                exists = false;
            }
        }

        return exists;
    }

    // 4. Add New Role
    public static int AddNewRole(string Description)
    {
        int newID = -1;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_AddNewRole", connection))
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
            catch { }
        }

        return newID;
    }

    // 5. Update Role
    public static bool UpdateRole(int RoleID, string Description)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_UpdateRole", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@Description", Description);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch { }
        }

        return rowsAffected > 0;
    }

    // 6. Delete Role
    public static bool DeleteRole(int RoleID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_DeleteRole", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RoleID", RoleID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch { }
        }

        return rowsAffected > 0;
    }
}
