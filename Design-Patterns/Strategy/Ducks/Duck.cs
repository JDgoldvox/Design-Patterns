using System;
using System.Collections.Generic;
using System.Text;

namespace Duck
{
    public class Duck
    {
        protected IFlyBehaviour flyBehaviour = new FlyWithWings();
        protected IQuackBehaviour quackBehaviour = new NormalQuack();

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            this.quackBehaviour = quackBehaviour;
        }
    }
}

