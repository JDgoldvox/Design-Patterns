using System;
using System.Collections.Generic;
using System.Text;

using FlyingBehaviour;
using QuackBehaviour;

namespace Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new Silence();
        }
    }
}
