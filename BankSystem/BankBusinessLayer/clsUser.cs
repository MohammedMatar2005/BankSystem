
using Bank_DataAccess;
using System.Data;

namespace Bank_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int RoleID { set; get; }
        public bool isActive { set; get; }

        public clsPersonData PersonInfo;

        public clsUser()
        {
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.isActive = false;
            this.RoleID = -1;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string Username, string Password, int RoleID, bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = Username;
            this.Password = Password;
            this.isActive = isActive;
            this.RoleID = RoleID;
            Mode = enMode.Update;
        }







        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        private bool _AddNewUser()
        {
            string hash = clsSecurity.ComputeHash(this.Password);

            this.UserID = clsUserData.AddNewUser(
                this.PersonID,
                this.UserName,
                hash,
                this.RoleID,
                this.isActive);

            this.Password = hash;
            return this.UserID != -1;
        }


        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.RoleID, this.isActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:

                    return _UpdateUser();

            }

            return false;

        }

        public static clsUser FindByUserID(int UserID)
        {

            int PersonID = 0; string UserName = ""; string Password = ""; bool isActive = false; int RoleID = 0;

            bool IsFound = clsUserData.GetUserInfoByUserID
                                (
                                    UserID, ref PersonID, ref UserName, ref Password, ref RoleID, ref isActive
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsUser(UserID, PersonID, UserName, Password, RoleID, isActive);
            else
                return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {

            int UserID = 0; string UserName = ""; string Password = ""; bool isActive = false; int RoleID = 0;

            bool IsFound = clsUserData.GetUsersInfoByPersonID
                                (
                                    PersonID, ref UserID, ref UserName, ref Password, ref RoleID, ref isActive
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsUser(UserID, PersonID, UserName, Password, RoleID, isActive);
            else
                return null;
        }


        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false; int RoleID = -1;

            string hash = clsSecurity.ComputeHash(Password);

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword(
                UserName, hash, ref UserID, ref PersonID, ref RoleID , ref IsActive);

            if (!IsFound)
                return null;

            return new clsUser(UserID, PersonID, UserName, hash, RoleID, IsActive);
        }


        public static bool isUserExist(int UserID)
        {
            return clsUserData.IsUserExistByUserID(UserID);
        }

        public static bool isUserExist(string UserName)
        {
            return clsUserData.IsUserExistByUsername(UserName);
        }

        public static bool isUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistByUserID(PersonID);
        }


        public static bool Delete(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

    }
}
