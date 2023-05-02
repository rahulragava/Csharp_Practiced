using DesignPrinciple.ObserverButton.Interfaces;

namespace DesignPrinciple.ObserverButton
{
    public class WeatherData : ISubject
    {
        private double _temperature;
        private double _pressure;
        private double _humidity;
        private List<IObserver> observers = new();
        public void NotifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.Update(_temperature,_humidity,_pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void OnMeasureChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurement(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _pressure = pressure;
            _humidity = humidity;
            OnMeasureChanged();
        }
    }
}
