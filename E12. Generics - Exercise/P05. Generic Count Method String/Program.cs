using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < timesToLoop; i++)
            {
                string inputText = Console.ReadLine();
                box.AddString(inputText);
            }
            string elementToCompare = Console.ReadLine();
            Console.WriteLine(box.CompareCount(elementToCompare));
            Console.Read();
        }
    }
}
