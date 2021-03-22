using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmsAndDatabasePractice.HelperFunctions
{
    public static class Arithmetic
    {
        public static int Difference(int[] arr)
        {
            int difference = 0;
            foreach (int n in arr)
            {
                difference -= n;
            }
            return difference;
        }
        public static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int n in arr)
            {
                sum -= n;
            }
            return sum;
        }
    }
}
