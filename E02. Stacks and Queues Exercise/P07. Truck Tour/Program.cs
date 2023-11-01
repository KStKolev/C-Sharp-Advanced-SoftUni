using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Truck_Tour
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i <= timesToLoop-1; i++)
            {
                int[] pumpArray = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(pumpArray);
            }
            int indexToRound = 0;
            bool isRound = false;
            while (!isRound)
            {
                isRound = true;
                int totalLiters = 0;
                foreach (var pump in pumps)
                {
                    int liters = pump[0];
                    int kilometers = pump[1];
                    totalLiters += liters;
                    if (totalLiters - kilometers < 0)
                    {
                        isRound = false;
                        indexToRound++;
                        int[] currentPump = pumps.Dequeue();
                        pumps.Enqueue(currentPump);
                        break;
                    }
                    totalLiters -= kilometers;
                }
            }
            if (isRound)
            {
                Console.WriteLine(indexToRound);
            }
            Console.Read();
        }
    }
}
