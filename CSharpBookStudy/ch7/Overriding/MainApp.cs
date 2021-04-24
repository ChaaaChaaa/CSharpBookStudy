using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.Overriding
{
    class MainApp : ArmorSuite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironMan = new IronMan();
            ironMan.Initialize();

            Console.WriteLine("\nCreating WarMaching...");
            ArmorSuite warMachine = new WarMachine();
            warMachine.Initialize();
        }
    }
}
