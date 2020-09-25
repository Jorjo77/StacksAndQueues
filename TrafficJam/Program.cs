using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            Queue<string> cars = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else if (input == "green")
                {
                    for (int i = 0; i < carsNumber; i++)
                    {
                        if (cars.Count==0)
                        {
                            break;
                        }
                        counter++;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
