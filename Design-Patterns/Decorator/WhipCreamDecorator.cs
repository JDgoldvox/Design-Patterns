
namespace Decorator
{
    public class WhipCreamDecorator : CondimentDecorator
    {
        public WhipCreamDecorator(IBeverage beverage) : base(beverage)
        {
            
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + "whip cream";
        }

        public override float GetCost()
        {
            return beverage.GetCost() + 0.99f;
        }
    }
}
