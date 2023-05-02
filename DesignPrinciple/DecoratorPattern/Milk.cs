using DesignPrinciple.DecoratorPattern.DecoratorInterface;

namespace DesignPrinciple.DecoratorPattern
{
    public class Milk : DecoratorAdditional
    {
        public Milk(IBeverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.59;
        }

        public override string Description()
        {
            return beverage.Description() + "Milk ";
        }
    }
}
