using Bank_DataAccess;
using BankDataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsUserData
{
    // 1. Get All Users
    public static DataTable GetAllUsers()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
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

    // 2. Get User By UserID
    public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref int RoleID, ref bool IsActive, ref string LoginCode)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        PersonID = (int)reader["PersonID"];
                        UserName = reader["UserName"].ToString();
                        Password = reader["Password"].ToString();
                        RoleID = (int)reader["RoleID"];
                        IsActive = (bool)reader["IsActive"];
                        LoginCode = reader["LoginCode"].ToString();
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

    // 3. Get User By PersonID
    public static bool GetUsersInfoByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref int RoleID, ref bool IsActive, ref string LoginCode)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetUserByPersonID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        UserID = (int)reader["UserID"];
                        UserName = reader["UserName"].ToString();
                        Password = reader["Password"].ToString();
                        RoleID = (int)reader["RoleID"];
                        IsActive = (bool)reader["IsActive"];
                        LoginCode = reader["LoginCode"].ToString();
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

    // 4. Add New User
    public static int AddNewUser(int PersonID, string UserName, string Password, int RoleID, bool IsActive,  string LoginCode)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@LoginCode", LoginCode);
            SqlParameter outputUserID = new SqlParameter("@NewUserID", SqlDbType.Int) { Direction = ParameterDirection.Output };

            command.Parameters.Add(outputUserID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                if (outputUserID.Value != DBNull.Value)
                    newID = (int)outputUserID.Value;

            
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }
        return newID;
    }

    // 5. Update User
    public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, int RoleID, bool IsActive)
    {
        bool isUpdated = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            SqlParameter outputRows = new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output };
            command.Parameters.Add(outputRows);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                isUpdated = outputRows.Value != DBNull.Value && (int)outputRows.Value > 0;
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }
        return isUpdated;
    }

    // 6. Delete User
    public static bool DeleteUser(int UserID)
    {
        bool isDeleted = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", UserID);

            SqlParameter outputRows = new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output };
            command.Parameters.Add(outputRows);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                isDeleted = outputRows.Value != DBNull.Value && (int)outputRows.Value > 0;
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }
        return isDeleted;
    }

    // 7. Check if User Exists by UserID
    public static bool IsUserExistByUserID(int UserID)
    {
        bool exists = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_IsUserExistByUserID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", UserID);

            SqlParameter output = new SqlParameter("@Exists", SqlDbType.Bit) { Direction = ParameterDirection.Output };
            command.Parameters.Add(output);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                exists = (bool)output.Value;
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }
        return exists;
    }

    // 8. Check if User Exists by PersonID
    public static bool IsUserExistByPersonID(int PersonID)
    {
        bool exists = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_IsUserExistByPersonID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);

            SqlParameter output = new SqlParameter("@Exists", SqlDbType.Bit) { Direction = ParameterDirection.Output };
            command.Parameters.Add(output);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                exists = (bool)output.Value;
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }
        return exists;
    }

    // 9. Check if Username Exists
    public static bool IsUserExistByUsername(string Username)
    {
        bool exists = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_IsUserExistByUsername", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", Username);

            SqlParameter output = new SqlParameter("@Exists", SqlDbType.Bit) { Direction = ParameterDirection.Output };
            command.Parameters.Add(output);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                exists = (bool)output.Value;
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }
        return exists;
    }

    // 10. Get User by Username and Password
    public static bool GetUserInfoByUsernameAndPassword(string Username, string Password, ref int UserID, ref int PersonID, ref int RoleID, ref bool IsActive, ref string LoginCode)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetUserByUsernameAndPassword", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        UserID = (int)reader["UserID"];
                        PersonID = (int)reader["PersonID"];
                        RoleID = (int)reader["RoleID"];
                        IsActive = (bool)reader["IsActive"];
                        LoginCode = reader["LoginCode"].ToString();
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

    // 11. Get User by LoginCode
    public static bool GetUserInfoByLoginCode(string LoginCode, ref int UserID, ref int PersonID, ref string UserName, ref string Password, ref int RoleID, ref bool IsActive)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetUserByLoginCode", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@LoginCode", LoginCode);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        UserID = (int)reader["UserID"];
                        PersonID = (int)reader["PersonID"];
                        UserName = reader["UserName"].ToString();
                        Password = reader["Password"].ToString();
                        RoleID = (int)reader["RoleID"];
                        IsActive = (bool)reader["IsActive"];
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

    public static DataTable GetAllUsers_View() 
    { 
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString)) 
        { 
            const string query = "SELECT * FROM User_Data"; using (SqlCommand command = new SqlCommand(query, connection))
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
                    EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); 
                }
            }
        } 
        return dt; 
    }
}
