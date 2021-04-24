using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.Overriding
{
    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }
}
