using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7
{
    class Cat
    {
        public string Name;
        public string Color;

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            Console.WriteLine($"{Name} : 잘가");
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
}
