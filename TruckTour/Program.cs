using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> circle = new Queue<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                circle.Enqueue(input);

            }
            int totalFuel = 0;
            for (int i = 0; i < n; i++)
            {
                string currentInfo = circle.Dequeue();
                var splitedInfo = currentInfo.Split().Select(int.Parse).ToArray();
                int fuel = splitedInfo[0];
                int distance = splitedInfo[1];
                totalFuel += fuel;
                if (totalFuel>=distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i=-1;
                }
                circle.Enqueue(currentInfo);
            }
            var firstElement = circle.Dequeue().Split();

            Console.WriteLine(firstElement[2]);
        }
    }
}
