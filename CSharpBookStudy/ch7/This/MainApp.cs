using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.This
{
    class MainApp
    {
        public static void Main(string[] args)
        {
            Employee MJ = new Employee();
            MJ.SetName("MJ");
            MJ.SetPosition("CEO");
            Console.WriteLine($"{MJ.GetName()} : {MJ.GetPosition()}");

            ThisConstructor a = new ThisConstructor();
            a.PrintFields();
            Console.WriteLine();

            ThisConstructor b = new ThisConstructor(1);
            b.PrintFields();
            Console.WriteLine();

            ThisConstructor c = new ThisConstructor(10,20);
            c.PrintFields();
            Console.WriteLine();
        }
    }
}
