using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> playList = new Queue<string>(songs);
            string command = Console.ReadLine();
            while (playList.Count > 0)
            {

                if (command.Contains("Play"))
                {
                    playList.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    var splittedCommand = command
                    .Split("Add ", StringSplitOptions.RemoveEmptyEntries);
                    if (!playList.Contains(splittedCommand[0]))
                    {
                        playList.Enqueue(splittedCommand[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{splittedCommand[0]} is already contained!");
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", playList));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
