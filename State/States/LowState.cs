using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    public class LowState : FanState
    {
        public override void TurnUp()
        {
            Console.WriteLine("Fan is on medium");
            _fan.ChangeState(new MediumState());
        }

        public override void TurnDown()
        {
            
        }
    }
}