using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Maximum_and_Minimum_Element
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timeToLoop = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < timeToLoop; i++)
            {
                int[] commands = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int command = commands[0];
                if (command == 1)
                {
                    numbers.Push(commands[1]);
                }
                else if (command == 2 && numbers.Count > 0)
                {
                    numbers.Pop();
                }
                else if (command == 3 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (command == 4 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(", ", numbers));
            }
            Console.Read();
        }
    }
}
