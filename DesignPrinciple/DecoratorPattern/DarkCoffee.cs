using DesignPrinciple.DecoratorPattern.DecoratorInterface;

namespace DesignPrinciple.DecoratorPattern
{
    public class DarkCoffee : IBeverage
    {
        public double Cost()
        {
            return 1.99;
        }

        public string Description()
        {
            return "Dark coffee ";
        }
    }
}
