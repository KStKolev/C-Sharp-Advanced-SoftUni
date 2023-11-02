﻿using System;
using System.Collections.Generic;

namespace P06._Record_Unique_Names
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfLoop = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < numberOfLoop; i++)
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
