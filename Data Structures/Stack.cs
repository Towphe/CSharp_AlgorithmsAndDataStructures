using System;

namespace AlogrithmsAndDatabasePractice.Data_Structures
{
    internal class Stack
    {
        // Last In First Out (LIFO)
        // This is a basic Stack implementation using Arrays
        // Note to self: Try making one using Linked lists next time
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];
        bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        internal bool Push(int n)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow.");
                return false;
            }
            else
            {
                stack[++top] = n;
                return true;
            }
        }
        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            } else
            {
                int value = stack[top--];
                return value;
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine($"Top of the element: {stack[top]}");
            }
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Stack contents:");
                for(int i=top; i>=0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
