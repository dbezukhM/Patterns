namespace Visitor.Interfaces
{
    public interface IEmployee
    {
        int GetSalary();
        void Accept(IVisitor visitor);
    }
}