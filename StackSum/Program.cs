using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(input);
            int sum = 0;
            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command=="end")
                {
                    break;
                }
                string[] splittedCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = splittedCommand[0];
                
                switch (action)
                {
                    case "add":
                        int firstNum = int.Parse(splittedCommand[1]);
                        int secondNum = int.Parse(splittedCommand[2]);
                        stack.Push(firstNum);
                        stack.Push(secondNum);
                        break;
                    case "remove":
                        int count = int.Parse(splittedCommand[1]);
                        if (count<=stack.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }

                        break;
                    default:
                        break;
                }
            }
            while (stack.Count>0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
