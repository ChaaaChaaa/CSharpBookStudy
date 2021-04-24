using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.Ingeritance
{
    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }

        public void DerivedMethod()
        {
            Console.WriteLine($"{this.Name}.DerivedMethod()");
        }
    }
}
