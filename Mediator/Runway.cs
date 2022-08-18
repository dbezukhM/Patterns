using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Runway
    {
        private bool _isAvailable = true;

        public void SetIsAvailable(bool isAvailable)
        {
            _isAvailable = isAvailable;
        }

        public bool IsAvailable()
        {
            return _isAvailable;
        }
    }
}
