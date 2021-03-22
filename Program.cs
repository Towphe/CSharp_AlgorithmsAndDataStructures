using System;
using AlogrithmsAndDatabasePractice.HelperFunctions;

namespace AlogrithmsAndDatabasePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr3 = { 5, 2, 6, 1, 3, 7, 4, 8 };

            Console.WriteLine($"arr1: {Arithmetic.Difference(arr1)}");
            Console.WriteLine($"arr2: {Arithmetic.Difference(arr2)}");
            Console.WriteLine($"arr3: {Arithmetic.Difference(arr3)}");
        }
        // 1, 2, 3, 4, 5, 6, 7, 8
        // !=1, 1, 0 -2, -5, -9, -14 -20
        // Starting from n=2: -3, -3, -4, -5, -6
    }
}
