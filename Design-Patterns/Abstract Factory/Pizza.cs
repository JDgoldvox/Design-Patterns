
namespace AbstractFactory
{
    public abstract class Pizza
    {
        protected IIngredientFactory ingredientFactory;
        protected string cheese;
        protected string sauce;
        protected string dough;
        protected string toppings;

        protected Pizza(IIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            Prepare();
        }
        
        private void Prepare()
        {
            dough = ingredientFactory.CreateDough();
            cheese = ingredientFactory.CreateCheese();
            sauce = ingredientFactory.CreateSauce();
            toppings = ingredientFactory.CreateToppings();

            Bake();
            Cut();
            Box();
            Description();
        }

        private void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        private void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        private void Box()
        {
            Console.WriteLine("Placing Pizza in box");
        }

        private void Description()
        {
            Console.WriteLine("This is a " + cheese + " pizza with " + sauce + " sauce and " + dough + " dough");
        }
    }
}
