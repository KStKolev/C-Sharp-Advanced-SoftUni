using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._Largest_3_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] listedNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = new List<int>();
            for (int i = 0; i < listedNumbers.Length; i++)
            {
                numbers.Add(listedNumbers[i]);
            }
            numbers = numbers.OrderByDescending(x => x).ToList();
            if (numbers.Count < 3)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        Console.Write($"{numbers[i]}");
                        continue;
                    }
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.Read();
        }
    }
}
