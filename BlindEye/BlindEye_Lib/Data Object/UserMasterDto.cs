using System;

namespace BlindEye_Lib.Data_Object
{
    public class UserMasterDto
    {
        #region Fields
        private long _UserMasterID;
        private string _UserName;
        private string _Password;
        private string _UserFullName;
        private DateTime _DateOfBirth;
        private string _Email;
        private string _PhoneNumber;
        private int _AccountType;
        private int _Rating;
        #endregion
        #region Properties
        public long UserMasterID
        {
            get { return _UserMasterID; }
            set { _UserMasterID = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string UserFullName
        {
            get { return _UserFullName; }
            set { _UserFullName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        public int AccountType
        {
            get { return _AccountType; }
            set { _AccountType = value; }
        }
        public int Rating
        {
            get { return _Rating; }
            set { _Rating = value; }
        }
        #endregion
    }
}
