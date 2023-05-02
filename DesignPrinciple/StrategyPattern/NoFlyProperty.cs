using DesignPrinciple.Interfaces;

namespace DesignPrinciple.StrategyPattern
{
    public class NoFlyProperty : IFly
    {
        public void Fly()
        {
            Console.WriteLine("no wings no fly");
        }
    }
}