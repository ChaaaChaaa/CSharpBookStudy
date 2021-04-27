//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpBookStudy.Ch9.AutoImplementedProperty
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo2 birthdayInfo2 = new BirthdayInfo2();
//            Console.WriteLine($"Name : {birthdayInfo2.Name}");
//            Console.WriteLine($"Birthday : {birthdayInfo2.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birthdayInfo2.Age}");

//            birthdayInfo2.Name = "미정";
//            birthdayInfo2.Birthday = new DateTime(1991,04,30);

//            Console.WriteLine($"Name : {birthdayInfo2.Name}");
//            Console.WriteLine($"Birthday : {birthdayInfo2.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birthdayInfo2.Age}");
//        }
//    }
//}
