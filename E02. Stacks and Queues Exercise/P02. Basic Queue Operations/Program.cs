using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Basic_Queue_Operations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] commandDigits = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int timesToPush = commandDigits[0];
            int timesToPop = commandDigits[1];
            int numberToSeek = commandDigits[2];
            Queue<int> numbers = new Queue<int>();
            int[] digitsArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < timesToPush; i++)
            {
                numbers.Enqueue(digitsArray[i]);
            }
            for (int i = 0; i < timesToPop; i++)
            {
                if (numbers.Count > 0)
                {
                    numbers.Dequeue();
                }
            }
            if (numbers.Count > 0)
            {
                if (numbers.Contains(numberToSeek))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.Read();
        }
    }
}
