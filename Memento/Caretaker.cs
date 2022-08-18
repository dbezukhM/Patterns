namespace Memento
{
    public class Caretaker<T> : IMemento<T> where T : struct
    {
        private T _state;

        public Caretaker(T state = default)
        {
            _state = state;
        }
        public T GetState()
        {
            return _state;
        }

        public void SetState(T state)
        {
            _state = state;
        }
    }
}