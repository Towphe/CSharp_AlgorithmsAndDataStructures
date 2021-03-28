using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmsAndDatabasePractice.Data_Structures
{
    // This is a basic array implementation of a Queue
    class Queue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;
        public Queue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }
        public void enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }
        public int dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                Console.WriteLine(ele[front] + "dequeued from queue");
                int p = ele[front++];
                Console.WriteLine($"Front item: {ele[front]}");
                Console.WriteLine($"Rear item: {ele[rear]}");
                return p;
            }
        }
        public void displayQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i=front; i<= rear; i++)
                {
                    Console.WriteLine(ele[i]);
                }
            }
        }
    }
}
