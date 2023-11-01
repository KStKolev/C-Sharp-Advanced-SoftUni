using System;

namespace P04._Symbol_in_Matrix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixProperties = int.Parse(Console.ReadLine());
            int rows = matrixProperties;
            char[] columns = new char[matrixProperties];
            char[,] matrix = new char[rows, columns.Length];
            for (int row = 0; row < rows; row++)
            {
                string symbols = Console.ReadLine();
                for (int i = 0; i < symbols.Length; i++)
                {
                    columns[i] = symbols[i];
                }
                for (int col = 0; col < columns.Length; col++)
                {
                    matrix[row, col] = columns[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isContaining = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns.Length; col++)
                {
                    if (matrix[row,col].Equals(symbol))
                    {
                        isContaining = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
                if (isContaining == true)
                {
                    break;
                }
            }
            if (!isContaining)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
            Console.Read();
        }
    }
}
