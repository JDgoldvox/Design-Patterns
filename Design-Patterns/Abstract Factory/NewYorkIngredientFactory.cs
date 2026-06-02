namespace AbstractFactory
{
    public class NewYorkIngredientFactory : IIngredientFactory
    {
        public string CreateCheese()            
        {
            return "Cheddar";
        }

        public string CreateSauce()
        {
            return "Marinara sauce";
        }

        public string CreateDough()
        {
            return "Thin crust";
        }

        public string CreateToppings()
        {
            return "basil";
        }
    }
}
