using System;
using System.Collections.Generic;
using System.Text;
using State.States;

namespace State
{
    public class Fan
    {
        private FanState _state;

        public Fan(FanState state)
        {
            ChangeState(state);
        }

        public void ChangeState(FanState state)
        {
            Console.WriteLine($"Fan: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void TurnUp()
        {
            _state.TurnUp();
        }

        public void TurnDown()
        {
            _state.TurnDown();
        }
    }
}