using System;
using Observer.Interfaces;

namespace Observer
{
    public class City : IObserver
    {
        private readonly string _name;
        private string _trafficUpdate;
        private readonly int _minStateValue;

        public City(string name)
        {
            _minStateValue = new Random().Next(0, 10);
            _name = name;

            Console.WriteLine($"City {_name} with min state value {_minStateValue} was created");
        }

        public void UpdateTraffic(string trafficUpdate)
        {
            _trafficUpdate = trafficUpdate;
        }

        public void Update(IObservable observable)
        {
            if (observable is TrafficUpdates trafficUpdates && trafficUpdates.State > _minStateValue)
            {
                Console.WriteLine($"City ({_name}): Reacted to the event with traffic state: {_trafficUpdate}.");
            }
        }
    }
}