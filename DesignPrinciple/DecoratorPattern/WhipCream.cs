using DesignPrinciple.DecoratorPattern.DecoratorInterface;

namespace DesignPrinciple.DecoratorPattern
{
    public class WhipCream : DecoratorAdditional
    {
        public WhipCream(IBeverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return beverage.Cost() + 1.99;
        }

        public override string Description()
        {
            return beverage.Description() + "Whip cream";
        }
    }
}
