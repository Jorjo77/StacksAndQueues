using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightConst = int.Parse(Console.ReadLine());
            int freeWindowConst = int.Parse(Console.ReadLine());
            int greenLight = greenLightConst;
            int freeWindow = freeWindowConst;

            int counter = 0;
            bool IsCrashed = false;
            while (greenLight >= 0)
            {

                string currCar = Console.ReadLine();
                if (currCar == "END")
                {
                    break;
                }
                else if (currCar=="green")
                {
                    greenLight = greenLightConst;
                    freeWindow = freeWindowConst;
                    currCar = Console.ReadLine();
                }

                if (currCar.Length > greenLight)
                {
                    char[] splittedCurrCar = currCar.ToCharArray();
                    Queue<char> splittedCar = new Queue<char>(splittedCurrCar);
                    while (greenLight>0)
                    {
                        splittedCar.Dequeue();
                        greenLight -= 1;
                    }
                    if (splittedCar.Count > 0)
                    {
                        while (freeWindow > 0 )
                        {
                            if (splittedCar.Count == 1)
                            {
                                splittedCar.Dequeue();
                                freeWindow--;
                                counter++;
                                break;
                            }
                            splittedCar.Dequeue();
                            freeWindow--;
                        }
                        if (splittedCar.Count > 0)
                        {
                            IsCrashed = true;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currCar} was hit at {splittedCar.Dequeue()}.");
                            break;
                        }
                        if (freeWindow < freeWindowConst)
                        {
                            break;
                        }

                        else
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    greenLight -= currCar.Length;
                    counter++;
                }

            }
            if (!IsCrashed)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counter} total cars passed the crossroads.");
            }
        }
    }
}
