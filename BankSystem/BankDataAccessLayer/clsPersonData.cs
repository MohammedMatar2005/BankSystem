
using Bank_DataAccess;
using BankDataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsPersonData
{


    // 1. Get All People (Returns DataTable)
    public static DataTable GetAllPeople()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            const string query = "SELECT * FROM People";
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
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return dt;
    }

    
    public static bool GetPeopleInfoByID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref bool Gender, ref string NationalNumber, ref string Address, ref string Email, ref string PhoneNumber, ref string ImagePath, ref DateTime BirthDate)
    {
        bool isFound = false;
        const string query = "SELECT * FROM People WHERE PersonID = @PersonID";

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
                        FirstName = (string)reader["FirstName"];
                        SecondName = (string)reader["SecondName"];
                        ThirdName = (string)reader["ThirdName"];
                        LastName = (string)reader["LastName"];
                        Gender = (bool)reader["Gender"];
                        NationalNumber = (string)reader["NationalNumber"];
                        Address = (string)reader["Address"];
                        Email = (string)reader["Email"];
                        PhoneNumber = (string)reader["PhoneNumber"];
                        ImagePath = (string)reader["ImagePath"];
                        BirthDate = (DateTime)reader["BirthDate"];

                    }
                }
            }
            catch (Exception ex) { isFound = false; }
        }
        return isFound;
    }

    // 3. Is People Exist
    public static bool IsPeopleExist(int PersonID)
    {
        bool isFound = false;
        const string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

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
            catch { isFound = false; }
        }
        return isFound;
    }

    // 4. Add New People
    public static int AddNewPeople(string FirstName, string SecondName, string ThirdName, string LastName, bool Gender, string NationalNumber, string Address, string Email, string PhoneNumber, string ImagePath, DateTime BirthDate)
    {
        int newID = -1;
        const string query = @"INSERT INTO People (FirstName, SecondName, ThirdName, LastName, Gender, NationalNumber, Address, Email, PhoneNumber, ImagePath, BirthDate) 
                               VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @Gender, @NationalNumber, @Address, @Email, @PhoneNumber, @ImagePath, @BirthDate); 
                               SELECT SCOPE_IDENTITY();";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    newID = insertedID;
            }
            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
        }
        return newID;
    }

    // 5. Update People
    public static bool UpdatePeople(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, bool Gender, string NationalNumber, string Address, string Email, string PhoneNumber, string ImagePath, DateTime BirthDate)
    {
        int rowsAffected = 0;
        const string query = @"UPDATE People SET FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, Gender = @Gender, NationalNumber = @NationalNumber, Address = @Address, Email = @Email, PhoneNumber = @PhoneNumber, ImagePath = @ImagePath, BirthDate = @BirthDate WHERE PersonID = @PersonID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);

            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
        }
        return (rowsAffected > 0);
    }

    // 6. Delete People
    public static bool DeletePeople(int PersonID)
    {
        int rowsAffected = 0;
        const string query = "DELETE FROM People WHERE PersonID = @PersonID";

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
        }
        return (rowsAffected > 0);
    }
}