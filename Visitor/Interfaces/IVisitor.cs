namespace Visitor.Interfaces
{
    public interface IVisitor
    {
        void Visit(Manager manager);
        void Visit(SalesPerson salesPerson);
        void Visit(StaffList staffList);
    }
}