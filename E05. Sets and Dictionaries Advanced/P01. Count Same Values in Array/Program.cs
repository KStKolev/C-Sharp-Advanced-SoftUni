using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Same_Values_in_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbersToDict = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            for (int i = 0; i < numbersToDict.Length; i++)
            {
                if (!numbers.ContainsKey(numbersToDict[i]))
                {
                    numbers.Add(numbersToDict[i], 1);
                }
                else
                {
                    numbers[numbersToDict[i]]++;
                }
            }
            foreach (var keyValuePair in numbers)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value} times");
            }
            Console.Read();
        }
    }
}
