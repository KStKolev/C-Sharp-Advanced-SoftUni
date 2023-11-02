namespace P05._Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<List<int>, List<int>> incrementNumbers = numbers =>
            {
                List<int> incrementedNumbers = new List<int>();
                foreach (var number in numbers)
                {
                    incrementedNumbers.Add(number + 1);
                }
                return incrementedNumbers;
            };
            Func<List<int>, List<int>> decrementNumbers = numbers =>
            {
                List<int> decrementedNumbers = new List<int>();
                foreach (var number in numbers)
                {
                    decrementedNumbers.Add(number - 1);
                }
                return decrementedNumbers;
            };
            Func<List<int>, List<int>> multiplyNumbers = numbers =>
            {
                List<int> multipliedNumbers = new List<int>();
                foreach (var number in numbers)
                {
                    multipliedNumbers.Add(number * 2);
                }
                return multipliedNumbers;
            };
            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                       numbers = incrementNumbers(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                    case "multiply":
                        numbers = multiplyNumbers(numbers);
                        break;
                    case "subtract":
                        numbers = decrementNumbers(numbers);
                        break;
                }
            }
            Console.Read();
        }
    }
}
