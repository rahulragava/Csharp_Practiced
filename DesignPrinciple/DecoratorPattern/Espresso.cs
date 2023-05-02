using DesignPrinciple.DecoratorPattern.DecoratorInterface;

namespace DesignPrinciple.DecoratorPattern
{
    public class Espresso : IBeverage
    {
        public double Cost()
        {
            return 2.99;
        }

        public string Description()
        {
            return "Espresso ";
        }

    }
}
