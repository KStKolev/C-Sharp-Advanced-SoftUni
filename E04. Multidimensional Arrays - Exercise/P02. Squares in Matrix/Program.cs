using System;
using System.Linq;

namespace P02._Squares_in_Matrix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] matrixProperties = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = matrixProperties[0];
            char[] columns = new char[matrixProperties[1]];
            char[,] matrix = new char[rows, columns.Length];
            for (int row = 0; row < rows; row++)
            {
                columns = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < columns.Length; col++)
                {
                    matrix[row, col] = columns[col];
                }
            }
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < columns.Length - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col ] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.Read();
        }
    }
}
