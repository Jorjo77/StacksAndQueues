using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue <string> kids = new Queue<string>(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            int tosses = int.Parse(Console.ReadLine());

            while (kids.Count>1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    //kids.Enqueue(kids.Dequeue());
                    string kid = kids.Dequeue();
                    kids.Enqueue(kid);
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
