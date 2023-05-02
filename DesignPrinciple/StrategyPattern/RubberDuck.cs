using DesignPrinciple.Interfaces;

namespace DesignPrinciple.StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFly flyingBehaviour, IDuckSound duckSoundBehaviour) : base(flyingBehaviour, duckSoundBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck...");
        }
    }
}