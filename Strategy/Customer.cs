using Strategy.Strategies;

namespace Strategy
{
    public class Customer
    {
        private IAccount _account;

        public Customer(IAccount account)
        {
            _account = account;
        }

        public void SetAccount(IAccount account)
        {
            _account = account;
        }

        public void MakePayment(int amount)
        {
            _account.MakePayment(amount);
        }
    }
}