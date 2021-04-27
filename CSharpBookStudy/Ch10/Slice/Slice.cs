//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpBookStudy.Ch10
//{
//    class Slice
//    {
//        static void PrintArr(System.Array arr)
//        {
//            foreach(var element in arr)
//            {
//                Console.Write(element);                
//            }
//            Console.WriteLine();
//        }

//        public static void Main(string[] args)
//        {
//            char[] arr = new char['Z' - 'A' + 1];
//            for(int i=0; i<arr.Length; i++)
//            {
//                arr[i] = (char)('A' + i);
//            }

//            PrintArr(arr[..]); //0~last
//            PrintArr(arr[5..]); // 5~last

//            Range range5_10 = 5..10;
//            PrintArr(arr[5..10]);

//            Index last = ^0;
//            Range range_5_last = 5..last;
//            PrintArr(arr[range_5_last]);

//            PrintArr(arr[^4..^1]);
//        }
//    }
//}
