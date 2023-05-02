namespace DesignPrinciple.Adapter_Pattern
{
    public class DuckAdapter : IDuck
    {
        Turkey turkey;

        public DuckAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            turkey.FlyLow();
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
