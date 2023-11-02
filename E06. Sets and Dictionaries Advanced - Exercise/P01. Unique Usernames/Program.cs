using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Unique_Usernames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int timesToLoop = int.Parse(Console.ReadLine());
            for (int i = 0; i < timesToLoop; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var currentName in names)
            {
                Console.WriteLine(currentName);
            }
            Console.Read();
        }
    }
}
