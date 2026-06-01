namespace Decorator
{
    public class CaramelDecorator : CondimentDecorator
    {
        public CaramelDecorator(IBeverage beverage) : base(beverage)
        {
            
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + "Caramel";
        }

        public override float GetCost()
        {
            return beverage.GetCost() + 0.77f;
        }
    }
}