
namespace AbstractFactory
{
    public interface IIngredientFactory
    {
        string CreateCheese();
        string CreateSauce();
        string CreateDough();
        string CreateToppings();
    }    
}
