using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            //От Stack<string> в char[]
            Stack<string> text = new Stack<string>();
            Stack<string> lastActions = new Stack<string>();
            Queue<string> actions = new Queue<string>();
            int commandsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsNumber; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                switch (action)
                {
                    case "1":
                        actions.Enqueue("1");
                        text.Push(command[1]);
                        lastActions.Push(command[1]);
                        break;
                    case "2":
                        actions.Enqueue("2");
                        lastActions.Push(text.Peek());
                        text.Pop();
                        break;
                    case "3":
                        int index = int.Parse(command[1]);
                        string[] currText = text.ToArray();
                        char[] currSymbols = currText[0].ToCharArray();
                        for (int j = 0; j < currSymbols.Length; j++)
                        {
                            if (currSymbols[j] == currSymbols[index - 1])
                            {
                                Console.WriteLine(currSymbols[j]);
                                break;
                            }
                        }
                        break;
                    case "4":
                        string currCommand = actions.Dequeue();
                        if (currCommand == "1")
                        {
                            text.Pop();
                            lastActions.Pop();
                        }
                        else if (currCommand == "2")
                        {
                            text.Push(lastActions.Pop());
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
//using System;
//using System.Collections.Generic;

//namespace Problem09SimpleTextEditor
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int numberOfOperations = int.Parse(Console.ReadLine());


//            string result = string.Empty;
//            Stack<string> stack = new Stack<string>();

//            for (int i = 1; i <= numberOfOperations; i++)
//            {
//                string[] currentCommand = Console.ReadLine()
//                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

//                if (currentCommand[0] == "1")
//                {
//                    stack.Push(result);
//                    string stringToAppend = currentCommand[1];
//                    result += stringToAppend;
//                }
//                else if (currentCommand[0] == "2")
//                {
//                    stack.Push(result);

//                    int count = int.Parse(currentCommand[1]);
//                    result = result.Substring(0, result.Length - count);

//                }
//                else if (currentCommand[0] == "3")
//                {
//                    int index = int.Parse(currentCommand[1]);

//                    Console.WriteLine(result[index - 1]);
//                }
//                else if (currentCommand[0] == "4")
//                {
//                    if (stack.Count > 0)
//                    {
//                        result = stack.Pop();
//                    }
//                    else
//                    {
//                        result = string.Empty;
//                    }
//                }
//            }
//        }
//    }
//}
