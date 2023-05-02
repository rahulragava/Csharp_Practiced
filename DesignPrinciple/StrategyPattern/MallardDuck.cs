using DesignPrinciple.Interfaces;

namespace DesignPrinciple.StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFly flyingBehaviour, IDuckSound duckSoundBehaviour) : base(flyingBehaviour, duckSoundBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck...");
        }
    }
}