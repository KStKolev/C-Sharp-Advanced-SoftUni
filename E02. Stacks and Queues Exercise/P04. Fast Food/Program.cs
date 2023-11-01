using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Fast_Food
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quanityOfFood = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Console.WriteLine(orders.Max());
            while (orders.Count > 0 && quanityOfFood >= orders.Peek())
            {
                int orderValue = orders.Peek();
                orders.Dequeue();
                quanityOfFood -= orderValue;
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            Console.Read();
        }
    }
}
