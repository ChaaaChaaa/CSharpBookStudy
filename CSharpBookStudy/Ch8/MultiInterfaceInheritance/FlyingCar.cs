using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch8.MultiInterfaceInheritance
{
    class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }

        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
    }
}
