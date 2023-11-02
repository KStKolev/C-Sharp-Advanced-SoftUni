namespace P02._Knights_of_Honor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Action<List<string>> print = name =>
            {
                foreach (var currentName in name)
                {
                    Console.WriteLine($"Sir {currentName}");
                }
            };
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            print(names);
            Console.Read();
        }
    }
}
