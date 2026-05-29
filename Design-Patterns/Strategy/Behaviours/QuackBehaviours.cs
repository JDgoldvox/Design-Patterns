using System;
using System.Collections.Generic;
using System.Text;

namespace QuackBehaviour
{
    public class NormalQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("*Quack*");
        }
    }

    public class Squeack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("*Squeack*");
        }
    }

    public class Silence : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("*Silence*");
        }
    }
}
