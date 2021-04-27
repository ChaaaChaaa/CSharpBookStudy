//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpBookStudy.Ch13.UsingCallback
//{
//    delegate int Compare(int a, int b);
//    class CompareSet
//    {
//        static int AscendCompare(int a, int b)
//        {
//            if (a > b)
//            {
//                return 1;
//            }
//            else if (a == b)
//            {
//                return 0;
//            }
//            else
//            {
//                return -1;
//            }
//        }

//        static int DescendCompare(int a, int b)
//        {
//            if (a < b)
//            {
//                return 1;
//            }
//            else if (a == b)
//            {
//                return 0;
//            }
//            else
//            {
//                return -1;
//            }
//        }

//        static void BubbleSort(int[] DataSet, Compare Comparer)
//        {
//            int i = 0;
//            int j = 0;
//            int temp = 0;

//            for (i = 0; i < DataSet.Length - 1; i++)
//            {
//                for (j = 0; j < DataSet.Length - (i + 1); j++)
//                {
//                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
//                    {
//                        temp = DataSet[j + 1];
//                        DataSet[j + 1] = DataSet[j];
//                        DataSet[j] = temp;
//                    }
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            int[] arr = { 3, 7, 4, 2, 10 };
//            Console.WriteLine("오름차순");
//            BubbleSort(arr, new Compare(AscendCompare));

//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write($"{arr[i]} ");
//            }
//            Console.WriteLine();

//            int[] arr2 = { 7, 2, 8, 10, 11 };
//            Console.WriteLine("내림차순");
//            BubbleSort(arr, new Compare(DescendCompare));

//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write($"{arr2[i]} ");
//            }
//        }
//    }
//}
