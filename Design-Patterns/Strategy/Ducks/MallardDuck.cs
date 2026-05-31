
using System;
using System.Collections.Generic;
using System.Text;

namespace Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new NormalQuack();
        }
    }
}

