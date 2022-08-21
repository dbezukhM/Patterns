using System;

namespace Strategy.Strategies
{
    public class PayPal : IAccount
    {
        public void MakePayment(int amount)
        {
            Console.WriteLine($"Payment of ${amount} made from PayPal.");
        }
    }
}