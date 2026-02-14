using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsActionTypesData
{
    // 1. Get All ActionTypes
    public static DataTable GetAllActionTypes()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetAllActionTypes", connection))
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
                throw new Exception("Error fetching all ActionTypes", ex);
            }
        }

        return dt;
    }

    // 2. Get Info By ID
    public static bool GetActionTypeInfoByID(int ActionTypeID, ref string Description)
    {
        bool isFound = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetActionTypeByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        Description = reader["Description"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error finding ActionType", ex);
            }
        }

        return isFound;
    }

    // 3. Is ActionType Exist
    public static bool IsActionTypeExist(int ActionTypeID)
    {
        bool exists = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_IsActionTypeExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    exists = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking ActionType existence", ex);
            }
        }

        return exists;
    }

    // 4. Add New ActionType
    public static int AddNewActionType(string Description)
    {
        int newID = -1;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_AddNewActionType", connection))
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
            catch (Exception ex)
            {
                throw new Exception("Error adding ActionType", ex);
            }
        }

        return newID;
    }

    // 5. Update ActionType
    public static bool UpdateActionType(int ActionTypeID, string Description)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_UpdateActionType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);
            command.Parameters.AddWithValue("@Description", Description);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating ActionType", ex);
            }
        }

        return (rowsAffected > 0);
    }

    // 6. Delete ActionType
    public static bool DeleteActionType(int ActionTypeID)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_DeleteActionType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ActionTypeID", ActionTypeID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting ActionType", ex);
            }
        }

        return (rowsAffected > 0);
    }
}
