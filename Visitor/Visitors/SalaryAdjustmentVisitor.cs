using System;
using Visitor.Interfaces;

namespace Visitor.Visitors
{
    public class SalaryAdjustmentVisitor : IVisitor
    {
        public void Visit(Manager manager)
        {
            manager.Salary = 65000;
        }

        public void Visit(SalesPerson salesPerson)
        {
            salesPerson.Salary = 57000;
        }

        public void Visit(StaffList staffList)
        {
            Console.WriteLine("Salary adjustments have been applied to all staff");
        }
    }
}