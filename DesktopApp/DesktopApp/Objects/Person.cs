
namespace DesktopApp.Objects
{
    public class Person
    {
        #region Fields
        protected int _id;
        private string _fName;
        private string _phone;
        private string _mobile;
        private string _email;
        private string _lName;
        private string _address;
        private string _city;
        #endregion

        #region Constructor

        public Person(string fName, string lName, string address, string city, string email, string mobile, string phone)
        {
            setStringValue(fName, ref _fName);
            setStringValue(lName, ref _lName);
            setStringValue(address, ref _address);
            setStringValue(city, ref _city);
            setStringValue(email, ref _email);
            setStringValue(mobile, ref _mobile);
            setStringValue(phone, ref _phone);
        }

        protected Person(Person p)
        {
            setStringValue(p._fName, ref _fName);
            setStringValue(p._lName, ref _lName);
            setStringValue(p._address, ref _address);
            setStringValue(p._city, ref _city);
            setStringValue(p._email, ref _email);
            setStringValue(p._mobile, ref _mobile);
            setStringValue(p._phone, ref _phone);
        }
        #endregion

        #region Getters & Setters
        #region Getter

        public int GetID() { return _id; }

        public string GetFname() { return _fName; }
        public string GetLname() { return _lName; }
        public string GetPhone() { return _phone; }
        public string GetMobile() { return _mobile; }
        public string GetEmail() { return _email; }
        public string GetAddress() { return _address; }

        public string GetCity() { return _city; }
        #endregion

        #region Setter
        private void setStringValue(string value, ref string item)
        {
            if (!string.IsNullOrWhiteSpace(value)) { item = value; }
        }
        #endregion
        #endregion

        #region Methods
        #endregion
    }
}