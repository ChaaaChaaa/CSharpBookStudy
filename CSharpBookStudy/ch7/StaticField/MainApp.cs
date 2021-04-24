using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.StaticField
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");

        }
    }
}
