﻿using System;
using System.Collections.Generic;

namespace P06._Supermarket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            Queue<string> customers = new Queue<string>();
            while ((command = Console.ReadLine()) != "End")
            {
                if (command != "Paid")
                {
                    customers.Enqueue(command);
                }
                else
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{customers.Count} people remaining.");
            Console.Read();
        }
    }
}
