namespace P07._Predicate_For_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            Predicate<string> matchNames = nameLength => nameLength.Length <= length;
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var currentName in names)
            {
                if (matchNames(currentName))
                {
                    Console.WriteLine(currentName);
                }
            }
            Console.Read();
        }
    }
}
