using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int elementsForDequeue = input[1];
            int target = input[2];
            int[] elements = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            Queue<int> queue = new Queue<int>(elements);
            for (int i = 0; i < elementsForDequeue; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count==0)
            {
                Console.WriteLine("0");
                return;
            }
            if (queue.Contains(target))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
