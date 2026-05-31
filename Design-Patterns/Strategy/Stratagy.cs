
//The Strategy Pattern defines a family of algorithms,
//encapsulates each one, and makes them interchangeable.
//Strategy lets the algorithm vary independently from
//clients that use it.

using Duck;

public class Stratagy : IPatternMain
{
    public void Run()
    {
        MallardDuck mallard = new();
        RubberDuck rubber = new();

        mallard.PerformFly();
        rubber.PerformFly();

        mallard.PerformQuack();
        rubber.PerformQuack();

        mallard.SetQuackBehaviour(new Silence());
        rubber.SetFlyBehaviour(new FlyWithRocket());
        mallard.PerformQuack();
        rubber.PerformFly();
    }
}

