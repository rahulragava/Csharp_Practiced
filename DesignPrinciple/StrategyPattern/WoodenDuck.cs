using DesignPrinciple.Interfaces;

namespace DesignPrinciple.StrategyPattern
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck(IFly flyingBehaviour, IDuckSound duckSoundBehaviour) : base(flyingBehaviour, duckSoundBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I am a Wooden Duck...");
        }
    }
}