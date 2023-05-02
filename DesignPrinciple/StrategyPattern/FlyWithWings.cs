using DesignPrinciple.Interfaces;

namespace DesignPrinciple.StrategyPattern
{
    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("wings");
        }
    }
}