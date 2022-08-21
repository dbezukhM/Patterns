using Strategy.Strategies;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(new BankAccount());

            customer.MakePayment(100);
            customer.SetAccount(new PayPal());
            customer.MakePayment(217);
        }
    }
}