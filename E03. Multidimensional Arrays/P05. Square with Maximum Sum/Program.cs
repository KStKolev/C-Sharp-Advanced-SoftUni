using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Square_with_Maximum_Sum
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int[] matrixProperties = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = matrixProperties[0];
            int[] columns = new int[matrixProperties[1]];
            int[,] matrix = new int[rows, columns.Length];
            for (int row = 0; row < rows; row++)
            {
                columns = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < columns.Length; col++)
                {
                    matrix[row, col] = columns[col];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        selectedRow = row;
                        selectedCol = col;
                    }

                }
            }

            Console.WriteLine($"{matrix[selectedRow, selectedCol]} {matrix[selectedRow, selectedCol + 1]}");
            Console.WriteLine($"{matrix[selectedRow + 1, selectedCol]} {matrix[selectedRow + 1, selectedCol + 1]}");
            Console.WriteLine(maxSum);
            Console.Read();
        }
    }
}
