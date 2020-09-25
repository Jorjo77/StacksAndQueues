using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(input);
            while (queue.Count>0)
            {
                if (queue.Peek() % 2 == 0&&queue.Count>1)
                {
                    Console.Write(queue.Dequeue() + ", ");
                }
                else if (queue.Peek() % 2 == 0 && queue.Count == 1)
                {
                    Console.Write(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }
        }
    }
}
