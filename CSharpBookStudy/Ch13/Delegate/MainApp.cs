//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpBookStudy.Ch13.Delegate
//{
//    class MainApp
//    {
//        delegate int MyDelegate(int a, int b);
//        static void Main(string[] args)
//        {
//            Calculator calculator = new Calculator();
//            MyDelegate Callback;

//            Callback = new MyDelegate(calculator.Plus);
//            Console.WriteLine(Callback(3, 4));

//            Callback = new MyDelegate(calculator.Minus);
//            Console.WriteLine(Callback(7, 4));
//        }
//    }
//}
