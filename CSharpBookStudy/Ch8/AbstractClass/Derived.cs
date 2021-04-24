using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch8.AbstractClass
{
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
}
