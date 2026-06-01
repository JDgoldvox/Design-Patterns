using Decorator;


namespace Decorator
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage beverage;

        public CondimentDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public abstract string GetDescription();
        public abstract float GetCost();
    }
}
