using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sunnyville = new City("Sunny Ville");
            var springfield = new City("Springfield");
            var trafficUpdates = new TrafficUpdates();

            trafficUpdates.Attach(sunnyville);
            trafficUpdates.Attach(springfield);

            sunnyville.UpdateTraffic("Congestion in town center");
            springfield.UpdateTraffic("Accident on the highway");
            trafficUpdates.SomeBusinessLogic();

            trafficUpdates.Detach(sunnyville);
            trafficUpdates.SomeBusinessLogic();
        }
    }
}
