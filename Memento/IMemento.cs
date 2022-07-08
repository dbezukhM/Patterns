namespace Memento
{
    public interface IMemento<T>
    {
        T GetState();
        void SetState(T state);
    }
}