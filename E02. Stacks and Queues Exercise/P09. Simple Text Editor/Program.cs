using System;
using System.Collections.Generic;

namespace P09._Simple_Text_Editor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = string.Empty;
            Stack<string> changes = new();
            int timesToLoop = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesToLoop; i++)
            {
                string[] commands = Console.ReadLine().Split();
                int command = int.Parse(commands[0]);
                switch (command)
                {
                    case 1:
                        changes.Push(text);
                        text += commands[1];
                        break;
                    case 2:
                        changes.Push(text);
                        int count = int.Parse(commands[1]);
                        text = text.Remove(text.Length - count);
                        break;
                    case 3:
                        int index = int.Parse(commands[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case 4:
                        text = changes.Pop();
                        break;
                }
            }
        }
    }
}