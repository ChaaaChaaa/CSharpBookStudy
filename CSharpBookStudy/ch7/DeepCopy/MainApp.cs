using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.DeepCopy
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                DoDeepCopy source = new DoDeepCopy();
                source.MyField1 = 10;
                source.MyField2 = 20;

                DoDeepCopy target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1},{source.MyField2}");
                Console.WriteLine($"{target.MyField1},{target.MyField2}");
            }

            Console.WriteLine("Deep Copy");
            {
                DoDeepCopy source = new DoDeepCopy();
                source.MyField1 = 10;
                source.MyField2 = 20;

                DoDeepCopy target = source.DeepCopyFunction();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1},{source.MyField2}");
                Console.WriteLine($"{target.MyField1},{target.MyField2}");
            }
        }
    }
}
