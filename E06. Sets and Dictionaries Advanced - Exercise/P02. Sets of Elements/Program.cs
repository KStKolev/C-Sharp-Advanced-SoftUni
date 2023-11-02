using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Sets_of_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] timesToLoop = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstRotateNumber = timesToLoop[0];
            int secondRotateNumber = timesToLoop[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < firstRotateNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < secondRotateNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            firstSet.IntersectWith(secondSet);
            if (firstSet.Count > 0)
            {
                Console.WriteLine(string.Join(" ", firstSet));
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.Read();
        }
    }
}
