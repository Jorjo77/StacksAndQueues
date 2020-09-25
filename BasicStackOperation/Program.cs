using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numberElementsForPop = input[1];
            int target = input[2];
            int[] elements = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
            Stack<int> stack = new Stack<int>(elements);
            for (int i = 0; i < numberElementsForPop; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }
            if (stack.Contains(target))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
