using System;
using System.Collections.Generic;

namespace P04._Product_Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopProduct = new SortedDictionary<string, Dictionary<string, double>>();
            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "Revision")
            {
                string[] commands = inputCommand.Split(", ");
                string shop = commands[0];
                string product = commands[1];
                double price = double.Parse(commands[2]);
                if (!shopProduct.ContainsKey(shop))
                {
                    shopProduct.Add(shop, new Dictionary<string, double>());
                    shopProduct[shop].Add(product, price);
                }
                else
                {
                    shopProduct[shop].Add(product, price);
                }
            }
            foreach (var keyValuePair in shopProduct)
            {
                Console.WriteLine($"{keyValuePair.Key}->");
                foreach (var valuePair in keyValuePair.Value)
                {
                    Console.WriteLine($"Product: {valuePair.Key}, Price: {valuePair.Value}");
                }
            }
            Console.Read();
        }
    }
}
