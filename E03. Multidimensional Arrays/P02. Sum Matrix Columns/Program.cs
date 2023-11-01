using System;
using System.Linq;

namespace P02._Sum_Matrix_Columns
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
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < columns.Length; col++)
                {
                    matrix[row, col] = columns[col];
                }
            }
            for (int col = 0; col < columns.Length; col++)
            {
                int sumForARow = 0;
                for (int row = 0; row < rows; row++)
                {
                    sumForARow += matrix[row, col];
                }
                Console.WriteLine(sumForARow);
            }
            Console.Read();
        }
    }
}
