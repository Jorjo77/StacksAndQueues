using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothesInTheBox);
            int currSum = 0;
            int racksNumber = 0;
            while (stack.Count>0)
            {

                while (currSum + stack.Peek() <= rackCapacity)
                {

                    currSum += stack.Pop();
                    if (stack.Count == 0)
                    {
                        break;
                    }
                }
                racksNumber++;
                currSum = 0;

            }
            Console.WriteLine(racksNumber);
        }
    }
}
