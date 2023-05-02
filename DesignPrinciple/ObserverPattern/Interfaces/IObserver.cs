namespace DesignPrinciple.ObserverButton.Interfaces
{
    public interface IObserver
    {
        void Update(double temperature, double humidity, double pressure);
    }
}
