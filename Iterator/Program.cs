using System;
using Iterator.Models;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee zak = new Employee("Zak");
            Employee sarah = new Employee("Sarah");
            Employee anna = new Employee("Anna");

            StaffList employees = new StaffList(zak, sarah, anna);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}