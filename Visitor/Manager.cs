using Visitor.Interfaces;

namespace Visitor
{
    public class Manager : IEmployee
    {
        public int Salary { get; set; } = 60000;
        public int GetSalary() => Salary;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}