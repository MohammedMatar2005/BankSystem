
using System;
using System.Data;
using Bank_DataAccess;
public class clsRoles
{
    public enum enMode { AddNew = 0, Update = 1 };
    public enMode Mode = enMode.AddNew;

    public int RoleID { get; set; }
    public string Description { get; set; }


    public clsRoles()
    {
        this.RoleID = -1;
        this.Description = "";
        Mode = enMode.AddNew;
    }

    private clsRoles(int RoleID, string Description)
    {
        this.RoleID = RoleID;
        this.Description = Description;

        Mode = enMode.Update;
    }

    public static clsRoles Find(int RoleID)
    {
        string Description = "";

        bool isFound = clsRolesData.GetRoleInfoByID(RoleID, ref Description);

        if (isFound)
            return new clsRoles(RoleID, Description);
        else
            return null;
    }

    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNewRole())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;

            case enMode.Update:
                return _UpdateRole();
        }
        return false;
    }

    private bool _AddNewRole()
    {
        this.RoleID = clsRolesData.AddNewRole(this.Description);
        return (this.RoleID != -1);
    }

    private bool _UpdateRole()
    {
        return clsRolesData.UpdateRole(this.RoleID, this.Description);
    }

    public static DataTable GetAllRoles()
    {
        return clsRolesData.GetAllRoles();
    }

    public static bool Delete(int RoleID)
    {
        return clsRolesData.DeleteRole(RoleID);
    }

    public static bool IsExist(int RoleID)
    {
        return clsRolesData.IsRoleExist(RoleID);
    }
}