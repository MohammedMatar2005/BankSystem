
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;
using Bank_Business;
using Bank_DataAccess;
using BankDataAccessLayer;

public class clsUserData
{

    public static DataTable GetAllUsers()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
           
            using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
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


    public static DataTable GetAllUsers_View()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM User_Data";
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
                    throw new Exception("Error fetching all Userss", ex);
                }
            }
        }
        return dt;
    }
    public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref int RoleID, ref bool IsActive)
    {
        bool isFound = false;
        const string query = "SELECT * FROM Users WHERE UserID = @UserID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
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
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        RoleID = (int)reader["RoleID"];
                        IsActive = (bool)reader["IsActive"];

                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error fetching Users info", ex); }
        }
        return isFound;
    }

    public static bool GetUsersInfoByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref int RoleID, ref bool IsActive)
    {
        bool isFound = false;
        const string query = "SELECT * FROM Users WHERE PersonID = @PersonID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
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
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        RoleID = (int)reader["RoleID"];
                        IsActive = (bool)reader["IsActive"];

                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error fetching Users info", ex); }
        }
        return isFound;
    }


    public static int AddNewUser(int PersonID, string UserName, string Password, int RoleID, bool IsActive)
    {
        int newID = -1;
        const string query = @"INSERT INTO Users (PersonID, UserName, Password, RoleID, IsActive) 
                               VALUES (@PersonID, @UserName, @Password, @RoleID, @IsActive); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    newID = insertedID;
            }
            catch (Exception ex) { throw new Exception("Error adding Users", ex); }
        }
        return newID;
    }

    public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, int RoleID, bool IsActive)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE Users 
                               SET PersonID = @PersonID, UserName = @UserName, Password = @Password, RoleID = @RoleID, IsActive = @IsActive 
                               WHERE UserID = @UserID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error updating Users", ex); }
        }
        return (rowsAffected > 0);
    }

    public static bool DeleteUser(int UserID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM Users WHERE UserID = @UserID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error deleting Users", ex); }
        }
        return (rowsAffected > 0);
    }


    public static bool IsUserExistByUserID(int UserID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isFound = (result != null);
            }
            catch (Exception ex) { throw new Exception("Error checking Users existence", ex); }
        }
        return isFound;
    }

    public static bool IsUserExistByPersonID(int PersonID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isFound = (result != null);
            }
            catch (Exception ex)
            { 
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }
        return isFound;
    }

    public static bool IsUserExistByUsername(string Username)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM Users WHERE Username = @Username";
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Username", Username);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isFound = (result != null);
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }
        return isFound;
    }


    public static bool GetUserInfoByUsernameAndPassword(string Username, string Password, ref int UserID, ref int PersonID, ref int RoleID , ref bool IsActive)
    {
        bool IsFound= false;

        string query = "SELECT * FROM Users WHERE UserName=@UserName AND Password=@Password";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))

            {
                

                command.Parameters.AddWithValue("@UserName", Username);
                command.Parameters.AddWithValue("@Password", Password);
                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;
                            UserID = (int)reader["UserID"];
                            PersonID = (int)reader["PersonID"];
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
        }
        return IsFound;

    }

    public static bool GetUserInfoByLoginCode(string LoginCode, ref int UserID, ref int PersonID, ref string UserName, ref string Password, ref int RoleID, ref bool IsActive)
    {
        bool isFound = false;
        const string query = "SELECT * FROM Users WHERE LoginCode = @LoginCode";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@UserID", UserID);
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
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        RoleID = (int)reader["RoleID"];
                        IsActive = (bool)reader["IsActive"];

                    }
                }
            }
            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
        }
        return isFound;
    }


}