using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch8.MultiInterfaceInheritance
{
    class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
