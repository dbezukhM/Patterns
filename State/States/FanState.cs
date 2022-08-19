namespace State.States
{
    public abstract class FanState
    {
        protected Fan _fan;

        public void SetContext(Fan fan)
        {
            _fan = fan;
        }

        public abstract void TurnUp();
        public abstract void TurnDown();
    }
}