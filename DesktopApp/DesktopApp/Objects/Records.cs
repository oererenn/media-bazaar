using System.Collections.Generic;

namespace DesktopApp.Objects
{
    class Records
    {
        #region Fields
        //private List<Employee> employeeList= new List<Employee>();
        private List<Person> peopleList = new List<Person>();
        #endregion

        #region Methods

        public List<Person> GetPersons()
        {
            heapSort(peopleList,peopleList.Count);
            return peopleList;
        }

        public void AddToList(Person person) { peopleList.Add(person); }

        public void EditEntry(int index, Person person)
        {
            if (index > 0 && index < peopleList.Count)
            {
                peopleList[index] = person;
            }
        }

        public void DeleteRecord(int index)
        {
            peopleList.RemoveAt(index);
        }

        #region Sort List
        private void heapSort(List<Person> list, int n)
        {
            for (var i = n / 2 - 1; i >= 0; i--)
            {
                heapify(list, n, i);
            }

            for (var i = n - 1; i >= 0; i--)
            {
                var temp = list[0];
                list[0] = list[i];
                list[i] = temp;
                heapify(list, i, 0);
            }
        }

        private void heapify(List<Person> list, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && list[left].GetID() > list[right].GetID())
            {
                largest = left;
            }

            if (right < n && list[left].GetID() < list[right].GetID())
            {
                largest = right;
            }

            if (largest != i)
            {
                var swap = list[i];
                list[i] = list[largest];
                list[largest] = swap;
                heapify(list,n, largest);
            }
        }
        #endregion
        #endregion
    }
}
