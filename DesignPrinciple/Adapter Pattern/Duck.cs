namespace DesignPrinciple.Adapter_Pattern
{
    public class Duck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Fly high");
        }

        public void Quack()
        {
            Console.WriteLine("Quack quack!!");
        }
    }
}
