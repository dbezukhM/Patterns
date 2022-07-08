using System;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(123);

            Mediator mediator = new Mediator(plane);

            mediator.TakeOff();
        }
    }
}
