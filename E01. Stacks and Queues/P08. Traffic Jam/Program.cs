using System;
using System.Collections.Generic;

namespace P08._Traffic_Jam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfPassingCars = int.Parse(Console.ReadLine());
            Queue<string> waitingCars = new Queue<string>();
            string inputCommand = string.Empty;
            int counter = 0;
            while ((inputCommand = Console.ReadLine()) != "end")
            {
                if (inputCommand != "green")
                {
                    waitingCars.Enqueue(inputCommand);
                }
                else
                {
                    for (int i = 0; i < numberOfPassingCars; i++)
                    {
                        if (waitingCars.Count > 0)
                        {
                            Console.WriteLine($"{waitingCars.Dequeue()} passed!");
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
            Console.Read();
        }
    }
}
