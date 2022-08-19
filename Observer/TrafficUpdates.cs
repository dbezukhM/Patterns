using System;
using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer
{
    public class TrafficUpdates : IObservable
    {
        public int State = 0;

        private readonly List<IObserver> _observers;

        public TrafficUpdates()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Attached an observer.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Detached an observer.");
            _observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine($"Notifying observers with state {State}...");
            _observers.ForEach(observer => observer.Update(this));
        }

        public void SomeBusinessLogic()
        {
            this.State = new Random().Next(0, 10);
            this.Notify();
        }
    }
}