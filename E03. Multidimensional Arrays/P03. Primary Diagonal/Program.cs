using System;
using System.Linq;

namespace P03._Primary_Diagonal
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
            int sumOfDiagonals = 0;
            for (int row = 0; row < rows; row++)
            {
                sumOfDiagonals += matrix[row, row];
            }
            Console.WriteLine(sumOfDiagonals);
            Console.Read();
        }
    }
}
