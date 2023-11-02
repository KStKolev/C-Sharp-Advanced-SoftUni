using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Periodic_Table
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            HashSet<string> uniqueComponents = new HashSet<string>();
            for (int i = 0; i < timesToLoop; i++)
            {
                string[] components = Console.ReadLine().Split();
                for (int l = 0; l < components.Length; l++)
                {
                    uniqueComponents.Add(components[l]);
                }
            }
            Console.WriteLine(string.Join(" ", uniqueComponents.OrderBy(x => x)));
            Console.Read();
        }
    }
}
