using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());
            while (queue.Count>0)
            {
                if (queue.Peek()<=quantityFood)
                {
                    quantityFood -= queue.Peek();
                    queue.Dequeue();
                }
                else
                {
                    Console.Write("Orders left: ");
                    while (queue.Count>0)
                    {
                        Console.Write (queue.Dequeue() + " ");
                    }
                    break;
                }
                if (queue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                }
            }
        }
    }
}
