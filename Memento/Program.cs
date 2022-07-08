using System;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adder adder = new Adder(new Caretaker<int>());
            adder.Add(10);
            Console.WriteLine(adder.GetResult());
            adder.Save();
            adder.Add(20);
            Console.WriteLine(adder.GetResult());
            adder.Undo();
            Console.WriteLine(adder.GetResult());
        }
    }
}