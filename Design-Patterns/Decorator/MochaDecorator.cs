namespace Decorator
{
    public class MochaDecorator : CondimentDecorator
    {
        public MochaDecorator(IBeverage beverage) : base(beverage)
        {
            
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + "Mocha";
        }

        public override float GetCost()
        {
            return beverage.GetCost() + 0.5f;
        }
    }
}