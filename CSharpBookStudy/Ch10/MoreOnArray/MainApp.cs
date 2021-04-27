//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpBookStudy.Ch10.MoreOnArray
//{
//    class MainApp
//    {
//        private static bool CheckPassed(int score)
//        {
//            return score >= 60;
//        }

//        private static void Print(int value)
//        {
//            Console.WriteLine($"{value}");
//        }

//        static void Main(string[] args)
//        {
//            int[] scores = new int[] { 80, 74, 81, 90, 34 };

//            foreach (int score in scores)
//            {
//                Console.Write($"{score}");
//            }

//            Console.WriteLine();

//            Array.Sort(scores);
//            Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();

//            Console.WriteLine($"차원 갯수 : {scores.Rank}");
//            Console.WriteLine($"이진 탐색 : 81 is at" + $"{Array.BinarySearch<int>(scores, 81)}");
//            Console.WriteLine($"모든 요소가 조건에 부합하는가? " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

//            //람다식
//            int index = Array.FindIndex<int>(scores, (score) => score < 60);
//            scores[index] = 61;

//            Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
//            Console.WriteLine("Old length of scores : " + $"{scores.GetLength(0)}");

//            Array.Resize<int>(ref scores, 10);
//            Console.WriteLine($"New length of scores : {scores.Length}");

//            Array.Clear(scores, 3, 7);
//            Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();
//        }
//    }
//}
