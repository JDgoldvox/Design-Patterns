namespace AbstractFactory;

public class NewYorkPizza : Pizza
{
    public NewYorkPizza (IIngredientFactory ingredientFactory) 
        : base(ingredientFactory)
    {
    }
}