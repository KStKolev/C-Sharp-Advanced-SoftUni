namespace P08._List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));
            int listLength = int.Parse(Console.ReadLine());
            HashSet<int> dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();
            List<int> numbers = new List<int>();
            for (int i = 1; i <= listLength; i++)
            {
                numbers.Add(i);
            }
            List<int> dividedNumbers = new List<int>();
            foreach (var number in numbers)
            {
                bool isDivided = true;
                foreach (var divider in dividers)
                {
                    Predicate<int> match = num => num % divider == 0;
                    if (!match(number))
                    {
                        isDivided = false;
                        break;
                    }
                }
                if (isDivided == true)
                {
                    dividedNumbers.Add(number);
                }
            }
            print(dividedNumbers);
            Console.Read();
        }
    }
}
