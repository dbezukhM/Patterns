using System;

namespace Strategy.Strategies
{
    public class BankAccount : IAccount
    {
        public void MakePayment(int amount)
        {
            Console.WriteLine($"Payment of ${amount} made from bank account.");
        }
    }
}