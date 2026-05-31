using System;
using System.Collections.Generic;
using System.Text;

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
