using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            //решение с TryPop по адванст
            //всички Try методи работят по подобен начин - за проверка на булеан условие!
            //char symbol; 
            //while (stack.TryPop(out symbol))
            //{
            //    Console.Write(symbol);
            //}
            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            //for (int i = 0; i < input.Length; i++)
            //{
            //    stack.Push(input[i]);
            //}

            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
