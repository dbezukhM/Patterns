using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Mediator
    {
        private readonly Plane _plane;
        private readonly PlanesInFlight _planesInFlight;
        private readonly PlanesOnGround _planesOnGround;
        private readonly Runway _runway;

        public Mediator(Plane plane, PlanesInFlight planesInFlight, PlanesOnGround planesOnGround, Runway runway)
        {
            _plane = plane;
            _planesInFlight = planesInFlight;
            _planesOnGround = planesOnGround;
            _runway = runway;
        }

        public Mediator(Plane plane)
        {
            _plane = plane;
            _planesOnGround = new PlanesOnGround();
            _planesInFlight = new PlanesInFlight();
            _runway = new Runway();
        }

        public void TakeOff()
        {
            if (!_plane.GetIsInTheAir() && _runway.GetIsAvailable())
            {
                Console.WriteLine($"Plane {_plane.GetId()} is taking off...");
                _planesOnGround.RemovePlane(_plane);
                _planesInFlight.AddPlane(_plane);
                _plane.SetIsInTheAir(true);
                _runway.SetIsAvailable(false);
            }
        }
    }
}