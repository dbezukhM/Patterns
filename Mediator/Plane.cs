using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Plane
    {
        private bool _isInTheAir = false;
        private int _id;

        public Plane(int id)
        {
            _id = id;
        }

        public bool GetIsInTheAir()
        {
            return _isInTheAir;
        }

        public void SetIsInTheAir(bool isInTheAir)
        {
            _isInTheAir = isInTheAir;
        }

        public int GetId()
        {
            return _id;
        }
    }
}