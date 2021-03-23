using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmsAndDatabasePractice.Algorithms
{
    // Currently under construction
    static class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            int[] arrangedArr = arr;
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0; j<arr.Length; i++)
                {
                    if (arr[i] - arr[i + 1] < 0)
                    {
                        int n1 = arr[i];
                        int n2 = arr[i + 1];
                        arrangedArr[i] = arr[i + 1];
                        arrangedArr[i + 1] = arr[i];
                        // switch arr[i] && arr[0]
                        // make an exception for the last one
                    }
                }
                // 1 2 3 4 5 ; 
            }
            return arrangedArr;
        }
        
    }
}
