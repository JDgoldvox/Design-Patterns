
namespace Decorator
{
    public class DarkRoast : IBeverage
    {
        public String description;
        public float cost;

        public DarkRoast()
        {
            description = "Dark Roast";
            cost = 1.0f;
        }
        
        public string GetDescription()
        {
            return description;
        }

        public float GetCost()
        {
            return cost;
        }
    }
}
