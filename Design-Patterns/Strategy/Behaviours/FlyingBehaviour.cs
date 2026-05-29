using System;
using System.Collections.Generic;
using System.Text;

namespace FlyingBehaviour
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with wings!");
        }
    }

    public class NoFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    public class FlyWithRocket : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
