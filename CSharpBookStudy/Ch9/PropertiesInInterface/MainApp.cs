using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch9.PropertiesInInterface
{
    class MainApp
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "박상현" };

            NamedValue height = new NamedValue()
            { Name = "키", Value = "177Cm" };

            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "90Kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
