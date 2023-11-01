using System;
using System.Linq;

namespace P01._Diagonal_Difference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixProperties = int.Parse(Console.ReadLine());
            int rows = matrixProperties;
            int[] columns = new int[matrixProperties];
            int[,] matrix = new int[rows, columns.Length];
            for (int row = 0; row < rows; row++)
            {
                columns = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < columns.Length; col++)
                {
                    matrix[row, col] = columns[col];
                }
            }
            int firstDiagonal = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = row; col <= row; col++)
                {
                    firstDiagonal += matrix[row, col];
                }
            }
            int secondDiagonal = 0;
            for (int row = 0; row < rows; row++)
            {
                    secondDiagonal += matrix[row, columns.Length - 1 - row];
            }
            int finalResult = Math.Abs(firstDiagonal - secondDiagonal);
            Console.WriteLine(finalResult);
            Console.Read();
        }
    }
}
