
namespace DesktopApp.Objects
{
    class Admin:Person
    {
        public Admin(string fName, string lName, string address, string city, string email, string mobile, string phone) :
            base(fName, lName, address, city, email, mobile, phone)
        {
        }
        public Admin(Person p) : base(p) { }
    }
}
