using System;
using System.Linq;

namespace P01._Sum_Matrix_Elements
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
            int maxSum = 0;
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
                    maxSum += matrix[row,col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(columns.Length);
            Console.WriteLine(maxSum);
            Console.Read();
        }
    }
}
