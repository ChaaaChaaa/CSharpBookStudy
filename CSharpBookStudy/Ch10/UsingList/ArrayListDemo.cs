﻿//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpBookStudy.Ch10.UsingList
//{
//    class ArrayListDemo
//    {
//        static void Main(string[] args)
//        {
//            ArrayList list = new ArrayList();
//            for (int i = 0; i < 5; i++)
//            {
//                list.Add(i);
//            }

//            foreach (object obj in list)
//            {
//                Console.Write($"{obj} ");
//            }
//            Console.WriteLine();

//            list.RemoveAt(2);

//            foreach (object obj in list)
//            {
//                Console.Write($"{obj} ");
//            }
//            Console.WriteLine();

//            list.Insert(2, 2);

//            foreach (object obj in list)
//            {
//                Console.Write($"{obj} ");
//            }
//            Console.WriteLine();

//            list.Add("abc");
//            list.Add("def");

//            for (int i = 0; i < list.Count; i++)
//            {
//                Console.Write($"{list[i]} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
