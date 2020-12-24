// using System;
// using System.IO;
//
// public class TestGenerator
// {
//     private static readonly Random Random = new Random();
//
//     private static int[] GetArray()
//     {
//         int length = Random.Next(20, 50 + 1);
//         int[] array = new int[length];
//         
//         for (int i = 0; i < length; ++i)
//         {
//             array[i] = Random.Next(10, 100);
//         }
//
//         return array;
//     }
//     
//     private static void GenerateInput()
//     {
//         for (int i = 1; i < 1 + 1; ++i)
//         {
//             using var sw = new StreamWriter($"../../../tests/{i:d2}");
//             sw.WriteLine(string.Join(' ', GetArray()));
//             sw.WriteLine(Random.Next(10, 100));
//         }
//     }
//
//     private static void GenerateOutput()
//     {
//         for (int i = 1; i < 1 + 1; ++i)
//         {
//             using (var sr = new StreamReader($"../../../tests/{i:d2}"))
//             {
//                 var christmasArray = new ChristmasArray(Array.ConvertAll(sr.ReadLine().Split(), int.Parse));
//                 var number = int.Parse(sr.ReadLine());
//
//                 using (var sw = new StreamWriter($"../../../tests/{i:d2}.a"))
//                 {
//                     try
//                     {
//                         sw.WriteLine(christmasArray[number]);
//                     }
//                     catch (ArgumentException e)
//                     {
//                         sw.WriteLine(e.Message);
//                     }
//                     
//                     sw.WriteLine($"{christmasArray.GetMetric():f3}");
//                 }
//             }
//         }
//     }
//     
//     public static void Main(string[] args)
//     {
//         // GenerateInput();
//         GenerateOutput();
//     }
// }