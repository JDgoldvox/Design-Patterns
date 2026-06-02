using AbstractFactory;

public class AbstractFactoryMain : IPatternMain
{
    public void Run()
    {
        Pizza hawaiian = new HawaiianPizza(new HawaiianIngredientFactory()); 
        Pizza newYork = new NewYorkPizza(new NewYorkIngredientFactory()); 
    }
}