

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
        public clsPerson person { set; get; }

        public string LoginCode { set; get; }



        public clsPersonData PersonInfo;

        public clsUser()
        {
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.isActive = false;
            this.RoleID = -1;
            this.LoginCode = "";
            Mode = enMode.AddNew;
            person = new clsPerson();
            
        }

        private clsUser(int UserID, int PersonID, string Username, string Password, int RoleID, bool isActive,  string loginCode)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = Username;
            this.Password = Password;
            this.isActive = isActive;
            this.RoleID = RoleID;
            Mode = enMode.Update;
            person = clsPerson.Find(PersonID);
            this.LoginCode = loginCode;
        }







        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static DataTable GetAllUsers_View()
        {
            return clsUserData.GetAllUsers_View();
        }

        private bool _AddNewUser()
        {
            string hash = clsSecurity.ComputeHash(this.Password);

            this.UserID = clsUserData.AddNewUser(
                this.PersonID,
                this.UserName,
                hash,
                this.RoleID,
                this.isActive,
                this.LoginCode
                );

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

            int PersonID = 0; string UserName = ""; string Password = ""; bool isActive = false; int RoleID = 0; string LoginCode = "";

            bool IsFound = clsUserData.GetUserInfoByUserID
                                (
                                    UserID, ref PersonID, ref UserName, ref Password, ref RoleID, ref isActive, ref LoginCode
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsUser(UserID, PersonID, UserName, Password, RoleID, isActive, LoginCode);
            else
                return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {

            int UserID = 0; string UserName = ""; string Password = ""; bool isActive = false; int RoleID = 0;string LoginCode = "";

            bool IsFound = clsUserData.GetUsersInfoByPersonID
                                (
                                    PersonID, ref UserID, ref UserName, ref Password, ref RoleID, ref isActive, ref LoginCode
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsUser(UserID, PersonID, UserName, Password, RoleID, isActive, LoginCode);
            else
                return null;
        }


        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false; int RoleID = -1; string LoginCode = "";

            string hash = clsSecurity.ComputeHash(Password);

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword(
                UserName, hash, ref UserID, ref PersonID, ref RoleID , ref IsActive, ref LoginCode);

            if (!IsFound)
                return null;

            return new clsUser(UserID, PersonID, UserName, hash, RoleID, IsActive, LoginCode);
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
            return clsUserData.IsUserExistByPersonID(PersonID);
        }


        public static bool Delete(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static clsUser GetUserInfoByLoginCode(string LoginCode)
        {
            int UserID = 0; string UserName = ""; string Password = ""; bool isActive = false; int RoleID = 0; int PersonID = 0;

            bool IsFound = clsUserData.GetUserInfoByLoginCode(LoginCode, ref UserID, ref PersonID, ref UserName, ref Password, ref RoleID, ref isActive);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, RoleID, isActive, LoginCode);
            else
                return null;
        }

    }
}
