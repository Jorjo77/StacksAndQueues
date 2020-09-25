using System;
using System.Collections.Generic;
using System.Threading;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else if (input != "Paid")
                {
                    queue.Enqueue(input);
                }
                else if (input == "Paid")
                {
                    while (queue.Count>0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
