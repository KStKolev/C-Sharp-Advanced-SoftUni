namespace P03._Custom_Min_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Func<HashSet<int>, int> minNumber = number =>
            {
                int minNumber = int.MaxValue;
                foreach (var currentDigit in number)
                {
                    if (minNumber > currentDigit)
                    {
                        minNumber = currentDigit;
                    }
                }
                return minNumber;
            };
            HashSet<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();
            Console.WriteLine(minNumber(numbers));
            Console.Read();
        }
    }
}
