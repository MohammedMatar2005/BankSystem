
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
            using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
            {

                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows) dt.Load(reader);
                    }
                }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return dt;
    }

    public static bool GetPeopleInfoByID(
     int PersonID,
     ref string FirstName,
     ref string SecondName,
     ref string ThirdName,
     ref string LastName,
     ref bool Gender,
     ref string NationalNumber,
     ref string Address,
     ref string Email,
     ref string PhoneNumber,
     ref string ImagePath,
     ref DateTime BirthDate)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
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
                        FirstName = reader["FirstName"].ToString();
                        SecondName = reader["SecondName"].ToString();
                        ThirdName = reader["ThirdName"] == DBNull.Value ? null : reader["ThirdName"].ToString();
                        LastName = reader["LastName"].ToString();
                        Gender = (bool)reader["Gender"];
                        NationalNumber = reader["NationalNumber"].ToString();
                        Address = reader["Address"].ToString();
                        Email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString();
                        PhoneNumber = reader["PhoneNumber"].ToString();
                        ImagePath = reader["ImagePath"] == DBNull.Value ? null : reader["ImagePath"].ToString();
                        BirthDate = (DateTime)reader["BirthDate"];
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


    // 3. Is People Exist
    public static bool IsPersonExist(int PersonID)
    {
        bool exists = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_IsPersonExist", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);

            SqlParameter output = new SqlParameter("@Exists", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Output
            };
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

    // 4. Add New People
    public static int AddNewPeople(
        string FirstName,
        string SecondName,
        string ThirdName,
        string LastName,
        bool Gender,
        string NationalNumber,
        string Address,
        string Email,
        string PhoneNumber,
        string ImagePath,
        DateTime BirthDate)
    {
        int newID = -1;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
               new SqlCommand("SP_AddNewPerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            command.Parameters.AddWithValue("@ThirdName",
                (object)ThirdName ?? DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@Address", Address);

            command.Parameters.AddWithValue("@Email",
                (object)Email ?? DBNull.Value);

            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            command.Parameters.AddWithValue("@ImagePath",
                (object)ImagePath ?? DBNull.Value);

            command.Parameters.AddWithValue("@BirthDate", BirthDate);

            // Output parameter
            SqlParameter outputId =
                new SqlParameter("@NewPersonID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

            command.Parameters.Add(outputId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                if (outputId.Value != DBNull.Value)
                    newID = (int)outputId.Value;
            }
            catch (Exception ex)
            {
                EventLogger.Log(
                    ex.ToString(),
                    System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return newID;
    }

    // 5. Update People
    public static bool UpdatePerson(
        int PersonID,
        string FirstName,
        string SecondName,
        string ThirdName,
        string LastName,
        bool Gender,
        string NationalNumber,
        string Address,
        string Email,
        string PhoneNumber,
        string ImagePath,
        DateTime BirthDate)
    {
        bool isUpdated = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command =
               new SqlCommand("SP_UpdatePerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            command.Parameters.AddWithValue("@ThirdName",
                (object)ThirdName ?? DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@Address", Address);

            command.Parameters.AddWithValue("@Email",
                (object)Email ?? DBNull.Value);

            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            command.Parameters.AddWithValue("@ImagePath",
                (object)ImagePath ?? DBNull.Value);

            command.Parameters.AddWithValue("@BirthDate", BirthDate);

            // Output parameter
            SqlParameter rowsAffected =
                new SqlParameter("@RowsAffected", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

            command.Parameters.Add(rowsAffected);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                isUpdated =
                    rowsAffected.Value != DBNull.Value &&
                    (int)rowsAffected.Value > 0;
            }
            catch (Exception ex)
            {
                EventLogger.Log(
                    ex.ToString(),
                    System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return isUpdated;
    }

    // 6. Delete People
    public static bool DeletePeople(int PersonID)
    {
        bool isDeleted = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            // Input parameter
            command.Parameters.AddWithValue("@PersonID", PersonID);

            // Output parameter
            SqlParameter outputRowsAffected = new SqlParameter("@RowsAffected", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(outputRowsAffected);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                // Check Output Parameter
                if (outputRowsAffected.Value != DBNull.Value)
                    isDeleted = (int)outputRowsAffected.Value > 0;
            }
            catch (Exception ex)
            {
                EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
        }

        return isDeleted;
    }

}