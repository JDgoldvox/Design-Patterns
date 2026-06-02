
namespace AbstractFactory
{
    public class HawaiianIngredientFactory : IIngredientFactory
    {
        public string CreateCheese()            
        {
            return "mozzarella";
        }

        public string CreateSauce()
        {
            return "Ranch Sauce";
        }

        public string CreateDough()
        {
            return "Thick Crust";
        }

        public string CreateToppings()
        {
            return "Pineapple and Pepperoni";
        }
    }    
}
