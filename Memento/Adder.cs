namespace Memento
{
    public class Adder
    {
        private int _result;
        private IMemento<int> _memento;

        public Adder(IMemento<int> memento)
        {
            _result = 0;
            _memento = memento;
        }

        public void Add(int newNumber)
        {
            _result += newNumber;
        }

        public int GetResult()
        {
            return _result;
        }

        public void Save()
        {
            _memento.SetState(_result);
        }

        public void Undo()
        {
            _result = _memento.GetState();
        }
    }
}