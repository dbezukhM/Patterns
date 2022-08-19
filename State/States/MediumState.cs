using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    public class MediumState : FanState
    {
        public override void TurnUp()
        {
            Console.WriteLine("Fan is on high");
            _fan.ChangeState(new HighState());
        }

        public override void TurnDown()
        {
            Console.WriteLine("Fan is on low");
            _fan.ChangeState(new LowState());
        }
    }
}