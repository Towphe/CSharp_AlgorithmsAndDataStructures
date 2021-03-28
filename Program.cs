using System;
using AlogrithmsAndDatabasePractice.Algorithms;
using AlogrithmsAndDatabasePractice.Data_Structures;
using AlogrithmsAndDatabasePractice.HelperFunctions;

namespace AlogrithmsAndDatabasePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Stack myStack = new Stack();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Peek();
            */
            int[] arr = { 3, 2, 1 };
            BubbleSort.Sort(arr);
            DisplayTools<int>.DisplayArray(arr);
        }
    }
}
