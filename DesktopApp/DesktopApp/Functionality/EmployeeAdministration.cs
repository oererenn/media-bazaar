using System.Collections.Generic;
using DesktopApp.Objects;

namespace DesktopApp.Functionality
{
    class EmployeeAdministration
    {
        #region Fields
        Records records = new Records();

        #endregion

        #region Methods
        #region Add Employee
        public void AddEmployee(Person employee)
        {
            if (employee.GetType() == typeof(Employee))
            {
                records.AddToList(employee);
            }
            else if (employee.GetType() == typeof(Admin))
            {
                records.AddToList(employee);
            }
        }
        #endregion
        #region Edit Employee Information
        private void editEmployee(Person person)
        {
            List<Person> list = records.GetPersons();
            int index = -1;
            Person pTemp = null;
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].GetID().Equals(person.GetID()))
                {
                    index = i;
                    pTemp = person;
                }
            }
            if (pTemp != null) { records.EditEntry(index, pTemp); }
        }

        public void EditEmployeeDetails(Person person)
        {
            string fname = person.GetFname();
            string lname = person.GetLname();
            string address = person.GetAddress();
            string city = person.GetCity();
            string email = person.GetEmail();
            string phone = person.GetPhone();
            string mobile = person.GetMobile();
            Person emp = new Person(fname, lname, address, city, email, mobile, phone);
            if (person.GetType() == typeof(Employee))
            {
                string skill = ((Employee) emp).GetSkill();
                double wage = ((Employee) emp).GetWage();
                string department = ((Employee) emp).GetDepartment();
                Employee tEmp = new Employee(emp, skill, wage, department);
                editEmployee(tEmp);
            }

            if (person.GetType() == typeof(Admin))
            {
                Admin tAdmin = new Admin(emp);
            }
        }
        #endregion

        #region Delete Employee

        public void DeleteEmployee(int id)
        {
            List<Person> tList = records.GetPersons();
            int index = -1;
            int min = 0, 
                n = tList.Count, 
                max = n - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (id > tList[mid].GetID())
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }

                if (id == tList[mid].GetID())
                {
                    index = mid;
                    break;
                }
            }
            if (index >= 0) { records.DeleteRecord(index); }
        }
        #endregion
        #endregion
    }
}
