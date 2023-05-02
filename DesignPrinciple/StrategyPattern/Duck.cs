using DesignPrinciple.Interfaces;

namespace DesignPrinciple.StrategyPattern
{
    public abstract class Duck
    {
        IFly _flyingBehaviour;
        IDuckSound _duckSoundBehaviour;

        public Duck(IFly flyingBehaviour, IDuckSound duckSoundBehaviour)
        {
            _flyingBehaviour = flyingBehaviour;
            _duckSoundBehaviour = duckSoundBehaviour;
        }
        public virtual void Swim()
        {
            Console.WriteLine("i can swim");
        }
        public abstract void Display();

        public void SetFlyingBehaviour(IFly flyingBehaviour)
        {
            _flyingBehaviour = flyingBehaviour;
        }
        public void SetDuckSoundBehaviour(IDuckSound duckSound)
        {
            _duckSoundBehaviour = duckSound;
        }
        public void PerformFly()
        {
            _flyingBehaviour.Fly();
        }
        public void PerformDuckSound()
        {
            _duckSoundBehaviour.DuckSound();
        }
    }
}