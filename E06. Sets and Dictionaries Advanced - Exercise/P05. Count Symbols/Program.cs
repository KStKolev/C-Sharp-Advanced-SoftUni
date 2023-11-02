using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Count_Symbols
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            string inputText = Console.ReadLine();
            foreach (var currentSymbol in inputText)
            {
                if (!symbols.ContainsKey(currentSymbol))
                {
                    symbols.Add(currentSymbol,1);
                }
                else
                {
                    symbols[currentSymbol]++; 
                }
            }
            foreach (var keyValuePair in symbols)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value} time/s");
            }
            Console.Read();
        }
    }
}
