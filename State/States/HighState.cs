using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    public class HighState : FanState
    {
        public override void TurnUp()
        {
            
        }

        public override void TurnDown()
        {
            Console.WriteLine("Fan is on medium");
            _fan.ChangeState(new MediumState());
        }
    }
}