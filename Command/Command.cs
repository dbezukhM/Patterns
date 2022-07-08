using Command.Service;

namespace Command
{
    public abstract class Command
    {
        protected readonly Jacket _jacket;

        protected Command(Jacket jacket)
        {
            _jacket = jacket;
        }

        public abstract void Execute();
    }
}