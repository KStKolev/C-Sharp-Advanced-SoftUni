using System;
using System.Collections.Generic;

namespace P04._Matching_Brackets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputSymbols = Console.ReadLine();
            char[] symbols = inputSymbols.ToCharArray();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i].Equals('('))
                {
                    indexes.Push(i);
                }
                else if (symbols[i].Equals(')'))
                {
                    int firstIndex = indexes.Pop();
                    for (int j = firstIndex; j <= i; j++)
                    {
                        Console.Write(inputSymbols[j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
