namespace P04._Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Predicate<int> evenMatch = evenNumber => evenNumber % 2 == 0;
            Predicate<int> oddMatch = oddnumber => oddnumber % 2 != 0;
            int[] rangeNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string printFilter = Console.ReadLine();
            int startRange = rangeNumbers[0];
            int endRange = rangeNumbers[1];
            Func<int, int, List<int>> arrayNumbers = (start, end) =>
            {
                List<int> collectedNumbers = new List<int>();
                for (int index = start; index <= end; index++)
                {
                    collectedNumbers.Add(index);
                }
                return collectedNumbers;
            };
            if (printFilter.Equals("odd"))
            {
                foreach (var currentNumber in arrayNumbers(startRange, endRange))
                {
                    if (oddMatch(currentNumber))
                    {
                        Console.Write($"{currentNumber} ");
                    }
                }
            }
            else
            {
                foreach (var currentNumber in arrayNumbers(startRange, endRange))
                {
                    if (evenMatch(currentNumber))
                    {
                        Console.Write($"{currentNumber} ");
                    }
                }
            }
            Console.Read();
        }
    }
}
