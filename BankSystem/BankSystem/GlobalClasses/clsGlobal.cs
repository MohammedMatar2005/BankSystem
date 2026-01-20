using Bank_Business;
using Bank_DataAccess;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    static class clsGlobal
    {
        public static clsUser CurrentUser;



        public static bool GetStoredCredentialFromRegistry(ref string InsertedUsername, ref string InsertedPassword)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string Username_ValueName = "Username";
            string Password_ValueName = "Password";

            try
            {
                string Username = Registry.GetValue(KeyPath, Username_ValueName, null) as string;
                string HashedPassword = Registry.GetValue(KeyPath, Password_ValueName, null) as string;

                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(HashedPassword))
                {
                    return false;
                }
                else
                {
                    InsertedUsername = Username;
                    InsertedPassword = HashedPassword;
                    return true;
                }


            }
            catch (Exception ex)
            {
                EventLoggerExtensions.LogError($"An Error occured: {ex.ToString()}", EventLogEntryType.Error);
                return false;
            }
        }

        public static bool SaveCredentialToRegistry(string Username, string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string Username_ValueName = "Username";
            string Password_ValueName = "Password";

            string HashedPassword = Password;

            try
            {
                Registry.SetValue(KeyPath, Username_ValueName, Username);
                Registry.SetValue(KeyPath, Password_ValueName, HashedPassword);
                return true;

            }
            catch (Exception ex)
            {
                EventLoggerExtensions.LogError($"An Error occured: {ex.ToString()}", EventLogEntryType.Error);
                return false;
            }
        }

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            if (string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password))
            {
                return SaveCredentialToRegistry("", "");
            }

            CurrentUser = clsUser.FindByUsernameAndPassword(Username, Password);

            if (CurrentUser != null)
            {
                return SaveCredentialToRegistry(Username, Password);
            }

            return false;
        }
    }



    //public static bool RememberUsernameAndPassword(string Username, string Password)
    //{

    //    try
    //    {
    //        //this will get the current project directory folder.
    //        string currentDirectory = System.IO.Directory.GetCurrentDirectory();


    //        // Define the path to the text file where you want to save the data
    //        string filePath = currentDirectory + "\\data.txt";

    //        //incase the username is empty, delete the file
    //        if (Username == "" && File.Exists(filePath))
    //        {
    //            File.Delete(filePath);
    //            return true;

    //        }

    //        // concatonate username and passwrod withe seperator.
    //        string dataToSave = Username + "#//#" + Password;

    //        // Create a StreamWriter to write to the file
    //        using (StreamWriter writer = new StreamWriter(filePath))
    //        {
    //            // Write the data to the file
    //            writer.WriteLine(dataToSave);

    //            return true;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show($"An error occurred: {ex.Message}");
    //        return false;
    //    }

    //}

    //public static bool GetStoredCredential(ref string Username, ref string Password)
    //{
    //    //this will get the stored username and password and will return true if found and false if not found.
    //    try
    //    {
    //        //gets the current project's directory
    //        string currentDirectory = System.IO.Directory.GetCurrentDirectory();

    //        // Path for the file that contains the credential.
    //        string filePath = currentDirectory + "\\data.txt";

    //        // Check if the file exists before attempting to read it
    //        if (File.Exists(filePath))
    //        {
    //            // Create a StreamReader to read from the file
    //            using (StreamReader reader = new StreamReader(filePath))
    //            {
    //                // Read data line by line until the end of the file
    //                string line;
    //                while ((line = reader.ReadLine()) != null)
    //                {
    //                    Console.WriteLine(line); // Output each line of data to the console
    //                    string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

    //                    Username = result[0];
    //                    Password = result[1];
    //                }
    //                return true;
    //            }
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show($"An error occurred: {ex.Message}");
    //        return false;
    //    }

    //}

}


