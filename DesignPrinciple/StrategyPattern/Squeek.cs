using DesignPrinciple.Interfaces;

namespace DesignPrinciple.StrategyPattern
{
    public class Squeek : IDuckSound
    {
        public void DuckSound() { Console.WriteLine("sqeeeek"); }
    }
}