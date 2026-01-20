
using System;
using System.Data;
using Bank_DataAccess;
public class clsClient
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int ClientID { get; set; }
    public int PersonID { get; set; }


    public clsClient()
    {
        this.ClientID = -1;
        this.PersonID = -1;        
        Mode = enMode.AddNew;
    }

    private clsClient(int ClientID, int PersonID)
    {
        this.ClientID = ClientID;
        this.PersonID = PersonID;

        Mode = enMode.Update;
    }

    public static clsClient Find(int ClientID)
    {
        int PersonID = -1;

        bool isFound = clsClientsData.GetClientInfoByID(ClientID, ref PersonID);

        if (isFound)
            return new clsClient(ClientID, PersonID);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewClient())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateClient();
        }
        return false;
    }

    private bool _AddNewClient()
    {
        this.ClientID = clsClientsData.AddNewClient(this.PersonID);
        return (this.ClientID != -1);
    }

    private bool _UpdateClient()
    {
        return clsClientsData.UpdateClient(this.ClientID, this.PersonID);
    }

    public static DataTable GetAllClients()
    {
        return clsClientsData.GetAllClients();
    }

    public static bool Delete(int ClientID)
    {
        return clsClientsData.DeleteClient(ClientID);
    }

    public static bool IsExist(int ClientID)
    {
        return clsClientsData.IsClientExist(ClientID);
    }
}