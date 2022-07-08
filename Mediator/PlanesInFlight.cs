using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class PlanesInFlight
    {
        private List<Plane> _planes;

        public PlanesInFlight()
        {
            _planes = new List<Plane>();
        }

        public void AddPlane(Plane plane)
        {
            _planes.Add(plane);
        }

        public void RemovePlane(Plane plane)
        {
            _planes.Remove(plane);
        }
    }
}