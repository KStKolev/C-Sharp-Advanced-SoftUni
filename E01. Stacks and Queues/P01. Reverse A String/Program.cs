using System;
using System.Collections.Generic;

namespace P01._Reverse_A_String
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Stack<char> symbols = new Stack<char>();

            foreach (var currentChar in inputText)
            {
                symbols.Push(currentChar);
            }

            while (symbols.Count > 0)
            {
                Console.Write(symbols.Pop());
            }
            Console.Read();

        }
    }
}
