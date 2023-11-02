namespace P11._TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<string, int, bool> firstName = (name, value) =>
            {
                int result = 0;
                foreach (var currentSymbol in name)
                {
                    result += currentSymbol;
                }
                return result >= value;
            };
            Func<List<string>, int, Func<string, int, bool>, string> getFirstName =
                (names, sum, match) => names.FirstOrDefault(name => match(name, sum));
            int value = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Console.WriteLine(getFirstName(names, value, firstName));
            Console.Read();
        }
    }
}
