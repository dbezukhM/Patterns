using System;
using State.States;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan = new Fan(new LowState());
            fan.TurnUp();
            fan.TurnUp();
            fan.TurnDown();
            fan.TurnDown();
            fan.TurnUp();
        }
    }
}