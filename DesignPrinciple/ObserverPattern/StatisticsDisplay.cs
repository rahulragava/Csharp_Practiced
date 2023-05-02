using DesignPrinciple.ObserverButton.Interfaces;

namespace DesignPrinciple.ObserverButton
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private WeatherData _weather;

        public StatisticsDisplay(WeatherData weather)
        {
            _weather = weather;
            _weather.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("displays current statistical display...");
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
