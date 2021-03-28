using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmsAndDatabasePractice.HelperFunctions
{
    public static class DisplayTools<T>
    {
        public static void DisplayArray(T[] arr)
        {
            foreach (var n in arr)
            {
                Console.WriteLine(n);
            }
        }
    }
}
