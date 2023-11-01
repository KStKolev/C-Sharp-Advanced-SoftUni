using System;
using System.Linq;

namespace P04._Matrix_Shuffling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] matrixProperties = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[matrixProperties[0], matrixProperties[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] columns = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columns[col];
                }
            }
            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "END")
            {
                string[] commands = inputCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commands.Length < 0 || commands.Length > 5 || commands[0] != "swap"
                    || int.Parse(commands[1]) > matrix.GetLength(0)
                    || int.Parse(commands[2]) > matrix.GetLength(1)
                    || int.Parse(commands[3]) > matrix.GetLength(0)
                    || int.Parse(commands[4]) > matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string command = commands[0];
                int firstGivenRow = int.Parse(commands[1]);
                int firstGivenCol = int.Parse(commands[2]);
                int secondGivenRow = int.Parse(commands[3]);
                int secondGivenCol = int.Parse(commands[4]);
                string firstSymbol = matrix[firstGivenRow, firstGivenCol];
                string secondSymbol = matrix[secondGivenRow, secondGivenCol];
                matrix[firstGivenRow, firstGivenCol] = secondSymbol;
                matrix[secondGivenRow, secondGivenCol] = firstSymbol;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row,col] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
