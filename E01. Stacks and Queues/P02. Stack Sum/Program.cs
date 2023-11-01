using System;
using System.Collections.Generic;

namespace P02._Stack_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split();
            int[] digitArray = new int[inputNumbers.Length];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                digitArray[i] = int.Parse(inputNumbers[i]);
            }
            Stack<int> numbers = new Stack<int>(digitArray);

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine().ToLower()) != "end")
            {
                string[] commandList = inputCommands.Split();
                string command = commandList[0];
                if (command.Equals("add"))
                {
                    int firstNumber = int.Parse(commandList[1]);
                    numbers.Push(firstNumber);
                    int secondNumber = int.Parse(commandList[2]);
                    numbers.Push(secondNumber);
                }
                else if (command.Equals("remove"))
                {
                    int indexToRemove = int.Parse(commandList[1]);
                    if (indexToRemove <= numbers.Count)
                    {
                        while (indexToRemove > 0)
                        {
                            numbers.Pop();
                            indexToRemove--;
                        }
                    }
                }
            }
            int sumOfStackNumbers = 0;
            foreach (var currentDigit in numbers)
            {
                sumOfStackNumbers += currentDigit;
            }
            Console.WriteLine($"Sum: {sumOfStackNumbers}");
            Console.Read();
        }
    }
}
