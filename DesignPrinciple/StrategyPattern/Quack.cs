using DesignPrinciple.Interfaces;

namespace DesignPrinciple.StrategyPattern
{
    public class Quack : IDuckSound
    {
        public void DuckSound() { Console.WriteLine("quaaack"); }
    }
}