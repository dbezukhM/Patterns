using System;

namespace Command.Service
{
    public class Jacket
    {
        public void placeOrder()
        {
            Console.WriteLine("Jacket order has been placed");
        }

        public void returnOrder()
        {
            Console.WriteLine("Jacket order has been returned");
        }
    }
}