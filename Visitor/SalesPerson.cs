using Visitor.Interfaces;

namespace Visitor
{
    public class SalesPerson : IEmployee
    {
        public int Salary { get; set; } = 50000;
        public int GetSalary() => Salary;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}