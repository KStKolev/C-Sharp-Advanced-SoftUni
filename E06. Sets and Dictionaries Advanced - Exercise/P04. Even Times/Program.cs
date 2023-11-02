using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Even_Times
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < timesToLoop; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else
                {
                    numbers[number] += 1;
                }
            }
            foreach (var currentNumber in numbers)
            {
                if (currentNumber.Value % 2 == 0)
                {
                    Console.WriteLine(currentNumber.Key);
                    break;
                }
            }
            Console.Read();
        }
    }
}

