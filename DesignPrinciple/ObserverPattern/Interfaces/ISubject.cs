namespace DesignPrinciple.ObserverButton.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoverObserver(IObserver observer);
        void NotifyObserver();
    }
}
