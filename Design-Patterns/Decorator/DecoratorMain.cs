using Decorator;

public class DecoratorMain : IPatternMain
{
    public void Run()
    {
        IBeverage beverage = new DarkRoast();
        
        beverage = new MochaDecorator(beverage);
        beverage = new CaramelDecorator(beverage);
        beverage = new WhipCreamDecorator(beverage);

        Console.WriteLine(beverage.GetDescription());
        Console.WriteLine(beverage.GetCost());
    }
}