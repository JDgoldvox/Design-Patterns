
namespace SingletonPattern
{
    public class Singleton
    {
        public static Singleton instance = new Singleton();
        
        private Singleton()
        {}

        public void DoSomething()
        {
            Console.WriteLine("Doing something");
        }
    }
}
