namespace DesignPrinciple.Adapter_Pattern
{
    public class Turkey : ITurkey
    {
        public void FlyLow()
        {
            Console.WriteLine("flying low");
        }

        public void Gobble()
        {
            Console.WriteLine("gobble gobble");
        }
    }
}
