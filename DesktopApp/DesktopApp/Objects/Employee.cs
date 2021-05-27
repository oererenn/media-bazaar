
namespace DesktopApp.Objects
{
    class Employee : Person
    {
        #region Fields
        private readonly string _skill;
        private readonly double _wage;
        private readonly string _contractType;
        private readonly string _department;

        private readonly int _workHours;
        private readonly int _weekHours;
        private readonly int _monthHours;
        
        private readonly bool _nightShift;
        private readonly bool _available;

        #endregion

        #region Constructors

        public Employee(string fName, string lName,string address, string city, string email, string mobile, string phone, string skill, double wage, int workHours) : 
            base(fName, lName, address, city, email, mobile, phone)
        {
            setStringValue(skill,ref _skill);
            setDoubleVlaue(wage, ref _wage);
            setIntValue(workHours, ref _workHours);
        }

        public Employee(Person p, string skill, double wage, string department) : base(p)
        {
            _skill = skill;
            _wage = wage;
            _department = department;
        }
        #endregion

        #region Getters & Setters
        #region Getters
        public string GetSkill() { return _skill; }
        public double GetWage() { return _wage; }

        public string GetDepartment() { return _department; }
        public int GetWorkHours() { return _workHours; }
        public int GetWeekHours() { return _weekHours; }

        public int GetMonthHours() { return _monthHours; }
        #endregion

        #region Setters

        private void setStringValue(string value, ref string item)
        {
            if (!string.IsNullOrWhiteSpace(value)) { item = value; }
        }

        private void setIntValue(int value, ref int item)
        {
            if (value >= 0) { item = value; }
        }
        private void setDoubleVlaue(double value, ref double item)
        {
            if (value >= 0) { item = value; }
        }

        #endregion

        #endregion

        #region Methods

        #endregion

        
    }
}
