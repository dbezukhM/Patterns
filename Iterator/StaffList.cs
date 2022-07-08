using System.Collections;
using System.Collections.Generic;
using Iterator.Models;

namespace Iterator
{
    public class StaffList : IEnumerable<Employee>
    {
        private Employee[] _employees;

        public StaffList(params Employee[] employees)
        {
            _employees = employees;
        }

        public Employee[] GetAll() => _employees;

        public IEnumerator<Employee> GetEnumerator()
        {
            return new StaffListIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}