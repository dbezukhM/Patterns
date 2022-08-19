namespace Observer.Interfaces
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}