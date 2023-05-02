using DesignPrinciple.DecoratorPattern.DecoratorInterface;

namespace DesignPrinciple.DecoratorPattern
{
    public abstract class DecoratorAdditional : IBeverage
    {
        protected IBeverage beverage;

        public DecoratorAdditional(IBeverage beverage)
        {
            this.beverage = beverage;
        }
        public abstract double Cost();
        public abstract string Description();
    }
}
