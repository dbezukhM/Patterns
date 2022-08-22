using System;
using Visitor.Visitors;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StaffList staffList = new StaffList();
            Console.WriteLine($"Total amount paid to staff: {staffList.GetSalary()}");

            staffList.Accept(new SalaryAdjustmentVisitor());
            Console.WriteLine($"New total amount paid to staff: {staffList.GetSalary()}");
        }
    }
}