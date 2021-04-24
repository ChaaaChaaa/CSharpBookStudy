using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.Ingeritance
{
    class MainApp
    {
        static void Main(String[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();
            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();

            Console.WriteLine();
            Console.WriteLine("Type Casting");

            Mammal mammalDog = new Dog();
            Dog dog;

            if(mammalDog is Dog)
            {
                dog = (Dog)mammalDog;
                dog.Bark();
            }

            Mammal mammalCat = new Cat();

            Cat cat = mammalCat as Cat;
            if(cat != null)
            {
                cat.Meow();
            }

            Cat cat2 = mammalDog as Cat;
            if(cat2 != null)
            {
                cat.Meow();
            }

            else
            {
                Console.WriteLine("cats is not a Cat");
            }
        }
    }
}
