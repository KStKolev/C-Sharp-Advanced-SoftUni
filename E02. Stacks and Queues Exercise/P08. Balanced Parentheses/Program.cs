using System;
using System.Collections.Generic;

namespace P08._Balanced_Parentheses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();
            Stack<char> openParentheses = new Stack<char>();
            bool isBalanced = true;
            foreach (var currentParenthese in parentheses)
            {
                switch (currentParenthese)
                {
                    case '{':
                    case '[':
                    case '(':
                        openParentheses.Push(currentParenthese);
                        break;
                    case '}':
                        if (openParentheses.Count > 0)
                        {
                            if (openParentheses.Peek().Equals('(') || openParentheses.Peek().Equals('['))
                            {
                                isBalanced = false;
                            }
                            else
                            {
                                openParentheses.Pop();
                            }
                        }
                        else
                        {
                            isBalanced = false;
                        }
                        break;
                    case ']':
                        if (openParentheses.Count > 0)
                        {
                            if (openParentheses.Peek().Equals('(') || openParentheses.Peek().Equals('{'))
                            {
                                isBalanced = false;
                            }
                            else
                            {
                                openParentheses.Pop();
                            }
                        }
                        else
                        {
                            isBalanced = false;
                        }
                        break;
                    case ')':
                        if (openParentheses.Count > 0)
                        {
                            if (openParentheses.Peek().Equals('{') || openParentheses.Peek().Equals('['))
                            {
                                isBalanced = false;
                            }
                            else
                            {
                                openParentheses.Pop();
                            }
                        }
                        else
                        {
                            isBalanced = false;
                        }
                        break;
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.Read();
        }
    }
}
