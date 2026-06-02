using SingletonPattern;

public class SingletonMain : IPatternMain
{
    public void Run()
    {
        Singleton.instance.DoSomething();
    }
}