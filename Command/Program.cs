using System;
using Command.Commands;
using Command.Service;

namespace Command
{
    internal class Program
    {
        private static Jacket jacket = new Jacket();

        static void Main(string[] args)
        {
            OrderHandler placeOrderHandler = new OrderHandler();
            OrderHandler returnOrderHandler = new OrderHandler();

            placeOrderHandler.invoke(new PlaceOrderCommand(jacket));
            returnOrderHandler.invoke(new ReturnOrderCommand(jacket));
        }
    }
}