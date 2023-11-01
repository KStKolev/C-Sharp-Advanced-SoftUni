using System;
using System.Collections.Generic;

namespace P03._Simple_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputMathExpressions = Console.ReadLine().Split();
            Stack<string> symbols = new Stack<string>(inputMathExpressions);
            int sumOfNumbers = 0;
            string sign = " ";
            string number = "0";
            while (symbols.Count > 1)
            {
                number = symbols.Pop();
                sign = symbols.Pop();

                if (sign.Equals("-"))
                {
                    sumOfNumbers -= int.Parse(number);
                }
                else if (sign.Equals("+"))
                {
                    sumOfNumbers += int.Parse(number);
                }
            }
            if (symbols.Count > 0)
            {
                number = symbols.Pop();
                sumOfNumbers += int.Parse(number);
            }
            Console.WriteLine(sumOfNumbers);
            Console.Read();
        }
    }
}
