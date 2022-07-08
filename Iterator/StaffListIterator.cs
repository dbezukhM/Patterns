using System.Collections;
using System.Collections.Generic;
using Iterator.Models;

namespace Iterator
{
    public class StaffListIterator : IEnumerator<Employee>
    {
        private StaffList _staffLists;
        private int position = -1;

        public StaffListIterator(StaffList staffList)
        {
            _staffLists = staffList;
        }

        public bool MoveNext()
        {
            if (position < _staffLists.GetAll().Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public Employee Current => _staffLists.GetAll()[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}