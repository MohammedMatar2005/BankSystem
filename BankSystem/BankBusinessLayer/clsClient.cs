
using System;
using System.Data;
// ÊÃßÏ ãä Úãá using áØÈŞÉ ÇáÏÇÊÇ ÃßÓÓ åäÇ ÅĞÇ ßÇäÊ İí ãÔÑæÚ ãÎÊáİ
// using YourProjectNameDataAccessLayer; 

public class clsClient
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int ClientID { get; set; }
    public int PersonID { get; set; }
    public DateTime ClientRegistrationDate { get; set; }
    public int CreatedByUserID { get; set; }


    // Constructor ááæÖÚ ÇáÇİÊÑÇÖí (ÅÖÇİÉ ÌÏíÏ)
    public clsClient()
    {
        this.ClientID = -1;
        // íãßäß åäÇ ÊÚííä Şíã ÇİÊÑÇÖíÉ áÈÇŞí ÇáÎÕÇÆÕ ÅĞÇ ÃÑÏÊ
        Mode = enMode.AddNew;
    }

    // Private Constructor áÇÓÊÎÏÇãå İí ãíËæÏ Find (æÖÚ ÇáÊÚÏíá)
    private clsClient(int ClientID, int PersonID, DateTime ClientRegistrationDate, int CreatedByUserID)
    {
        this.ClientID = ClientID;
        this.PersonID = PersonID;
        this.ClientRegistrationDate = ClientRegistrationDate;
        this.CreatedByUserID = CreatedByUserID;

        Mode = enMode.Update;
    }

    // ãíËæÏ Find
    public static clsClient Find(int ClientID)
    {
        int PersonID = -1;
        DateTime ClientRegistrationDate = DateTime.Now;
        int CreatedByUserID = -1;

        bool isFound = clsClientsData.GetClientInfoByID(ClientID, ref PersonID, ref ClientRegistrationDate, ref CreatedByUserID);

        if (isFound)
            return new clsClient(ClientID, PersonID, ClientRegistrationDate, CreatedByUserID);
        else
            return null;
    }

    // ãíËæÏ Save (ÊŞæã ÈÇáÅÖÇİÉ Ãæ ÇáÊÚÏíá ÊáŞÇÆíÇğ)
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
        this.ClientID = clsClientsData.AddNewClient(this.PersonID, this.ClientRegistrationDate, this.CreatedByUserID);
        return (this.ClientID != -1);
    }

    private bool _UpdateClient()
    {
        return clsClientsData.UpdateClient(this.ClientID, this.PersonID, this.ClientRegistrationDate, this.CreatedByUserID);
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