using System.Collections.Generic;
using System.Linq;
using Visitor.Interfaces;

namespace Visitor
{
    public class StaffList : IEmployee
    {
        private List<IEmployee> employees;

        public StaffList()
        {
            employees = new List<IEmployee>
            {
                new Manager(),
                new SalesPerson(),
                new SalesPerson()
            };
        }

        public int GetSalary() => employees.Select(e => e.GetSalary()).Sum();

        public void Accept(IVisitor visitor)
        {
            employees.ForEach(e => e.Accept(visitor));
            visitor.Visit(this);
        }
    }
}