//using DesignPrinciple.ObserverButton.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPrinciple.ObserverButton
//{

//    public class ObserverPattern
//    {
//        public static void Main()
//        {
//            WeatherData weatherData = new WeatherData();
//            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
//            StatisticsDisplay statisticalDisplay = new StatisticsDisplay(weatherData);

//            weatherData.SetMeasurement(99.23, 41.55, 51.45);
//            currentConditionDisplay.Display();
//            weatherData.SetMeasurement(199.23, 141.55, 511.45);
//            statisticalDisplay.Display();
//            Console.ReadKey();

//        }
//    }
//}
