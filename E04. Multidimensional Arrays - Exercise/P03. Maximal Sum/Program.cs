using System;
using System.Linq;

namespace P03._Maximal_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] matrixProperties = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[matrixProperties[0], matrixProperties[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columns = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columns[col];
                }
            }
            int biggestValue = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentValue = 0;
                    currentValue += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentValue > biggestValue)
                    {
                        biggestValue = currentValue;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentValue = 0;
                    currentValue += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentValue == biggestValue)
                    {
                        Console.WriteLine($"Sum = {biggestValue}");
                        Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}");
                        Console.WriteLine($"{matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}");
                        Console.WriteLine($"{matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}");
                        return;
                    }
                }
            }
        }
    }
}
