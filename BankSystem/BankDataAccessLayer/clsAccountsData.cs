
using System;
using System.Data;
using System.Data.SqlClient;
using BankDataAccessLayer;

public class clsAccountsData
{
    // --- Properties ---
    public int AccountID { get; set; }
    public int ClientID { get; set; }
    public string AccountNumber { get; set; }
    public string Password { get; set; }
    public decimal Balance { get; set; }


    // 1. Get All Accounts (Returns DataTable)
    public static DataTable GetAllAccounts()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM Accounts";
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
                catch (Exception ex) { throw new Exception("Error fetching all Accounts", ex); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID (Find)
    public static bool GetAccountInfoByID(int AccountID, ref int ClientID, ref string AccountNumber, ref string Password, ref decimal Balance)
    {
        bool isFound = false;
        const string query = "SELECT * FROM Accounts WHERE AccountID = @AccountID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
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
                        AccountNumber = (string)reader["AccountNumber"];
                        Password = (string)reader["Password"];
                        Balance = (decimal)reader["Balance"];

                    }
                }
            }
            catch { isFound = false; }
        }
        return isFound;
    }

    // 3. Is Account Exist
    public static bool IsAccountExist(int AccountID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM Accounts WHERE AccountID = @AccountID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@AccountID", AccountID);
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

    // 4. Add New Account
    public static int AddNewAccount(int ClientID, string AccountNumber, string Password, decimal Balance)
    {
        int newID = -1;
        const string query = @"INSERT INTO Accounts (ClientID, AccountNumber, Password, Balance) 
                               VALUES (@ClientID, @AccountNumber, @Password, @Balance); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Balance", Balance);

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

    // 5. Update Account
    public static bool UpdateAccount(int AccountID, int ClientID, string AccountNumber, string Password, decimal Balance)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE Accounts SET ClientID = @ClientID, AccountNumber = @AccountNumber, Password = @Password, Balance = @Balance WHERE AccountID = @AccountID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Balance", Balance);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete Account
    public static bool DeleteAccount(int AccountID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM Accounts WHERE AccountID = @AccountID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@AccountID", AccountID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch { }
        }
        return (rowsAffected > 0);
    }
}