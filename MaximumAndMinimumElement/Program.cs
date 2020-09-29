using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsNumber = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < commandsNumber; i++)
            {
                int[] commands = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                string command = commands[0].ToString();
                switch (command)
                {
                    case "1":
                        int element = commands[1];
                        stack.Push(element);
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        if (stack.Count>0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case "4":
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                    default:
                        throw new ArgumentException();
                }

            }
            while (stack.Count > 0)
            {
                if (stack.Count > 1)
                {
                    Console.Write(stack.Pop() + ", ");
                }
                else if (stack.Count == 1)
                {
                    Console.Write(stack.Pop());
                }
                //Console.Write(string.Join(", ", stack));
            }
        }
    }
}
