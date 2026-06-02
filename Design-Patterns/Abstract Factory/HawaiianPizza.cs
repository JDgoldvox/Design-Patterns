

namespace AbstractFactory
{
    public class HawaiianPizza : Pizza
    {
        public HawaiianPizza(IIngredientFactory ingredientFactory) :
            base(ingredientFactory)
        {
        }
    }
}
