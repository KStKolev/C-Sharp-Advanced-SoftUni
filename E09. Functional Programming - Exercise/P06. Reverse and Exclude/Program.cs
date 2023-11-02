namespace P06._Reverse_and_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<List<int>, List<int>> reversedNumbers = number =>
            {
                List<int> reversedIntegers = new List<int>();
                for (int i = number.Count - 1; i >= 0; i--)
                {
                    reversedIntegers.Add(number[i]);
                }
                return reversedIntegers;
            };
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int inputDivider = int.Parse(Console.ReadLine());
            Predicate<int> divider = number => number % inputDivider == 0;
            numbers = reversedNumbers(numbers);
            foreach (var currentNumber in numbers)
            {
                if (!divider(currentNumber))
                {
                    Console.Write($"{currentNumber} ");
                }
            }
            Console.Read();
        }
    }
}
