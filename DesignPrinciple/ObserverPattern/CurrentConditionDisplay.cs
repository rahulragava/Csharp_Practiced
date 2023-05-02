using DesignPrinciple.ObserverButton.Interfaces;

namespace DesignPrinciple.ObserverButton
{
    public class CurrentConditionDisplay : IObserver, IDisplay
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private ISubject _weather;

        public CurrentConditionDisplay(ISubject weather)
        {
            _weather = weather;
            _weather.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("displays current condition display...");
            Console.WriteLine($" temperature : { _temperature } \n Pressure : {_pressure}\n Humidity : {_humidity}" );
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }
    }
}
