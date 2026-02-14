using System;
using System.Data;
using System.Data.SqlClient;
using Bank_DataAccess;
using BankDataAccessLayer;

public class clsAccountsData
{
    // 1. Get All Accounts
    public static DataTable GetAllAccounts()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetAllAccounts", connection))
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
                throw new Exception("Error fetching accounts", ex);
            }
        }

        return dt;
    }

    // 2. Get Account By ID
    public static bool GetAccountInfoByID(
        int AccountID,
        ref int ClientID,
        ref string AccountNumber,
        ref string Password,
        ref decimal Balance,
        ref string PinCode,
        ref int CurrencyID)
    {
        bool isFound = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_GetAccountByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;

                        ClientID = (int)reader["ClientID"];
                        AccountNumber = reader["AccountNumber"].ToString();
                        Password = reader["Password"].ToString();
                        Balance = Convert.ToDecimal(reader["Balance"]);
                        PinCode = reader["PinCode"].ToString();
                        CurrencyID = (int)reader["CurrencyID"];
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

    // 3. Is Account Exist
    public static bool IsAccountExist(int AccountID)
    {
        bool exists = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_IsAccountExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    exists = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking account existence", ex);
            }
        }

        return exists;
    }


    // 4. Add New Account
    public static int AddNewAccount(
        
        int ClientID,
        string AccountNumber,
        string Password,
        decimal Balance,
        string PinCode,
        int CurrencyID)
    {
        int AccountID = -1;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_AddAccount", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

          
             

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AccountID = insertedID;
                }
            }
            catch(Exception ex) 
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return AccountID;
    }

    // 5. Update Account
    public static bool UpdateAccount(
        int AccountID,
        int ClientID,
        string AccountNumber,
        string Password,
        decimal Balance,
        string PinCode,
        int CurrencyID)
    {
        bool success = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_UpdateAccount", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            try
            {
                connection.Open();
                success = (command.ExecuteNonQuery() > 0);
            }
            catch
            {
                success = false;
            }
        }

        return success;
    }

    // 6. Delete Account
    public static bool DeleteAccount(int AccountID)
    {
        bool success = false;

        using (SqlConnection connection =
            new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
            new SqlCommand("SP_DeleteAccount", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();
                success = (command.ExecuteNonQuery() > 0);
            }
            catch
            {
                success = false;
            }
        }

        return success;
    }
}
