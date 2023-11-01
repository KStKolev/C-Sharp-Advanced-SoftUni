using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Print_Even_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] digitsArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> numbers = new Queue<int>(digitsArray);
            List<int> evenNumbers = new List<int>(); 
            while (numbers.Count > 0)
            {
                int number = numbers.Dequeue();
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.Read();
        }
    }
}
