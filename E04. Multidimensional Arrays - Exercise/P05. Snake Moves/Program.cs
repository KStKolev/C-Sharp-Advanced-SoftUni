using System;
using System.Linq;

namespace P05._Snake_Moves
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
            int columns = matrixProperties[1];
            string symbols = Console.ReadLine();
            char[,] matrix = new char[rows, columns];
            int currentIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        if (currentIndex.Equals(symbols.Length))
                        {
                            currentIndex = 0;
                        }
                        matrix[row, col] = symbols[currentIndex];
                        Console.Write(matrix[row, col]);
                        currentIndex++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int col = columns - 1; col >= 0; col--)
                    {
                        if (currentIndex.Equals(symbols.Length))
                        {
                            currentIndex = 0;
                        }
                        matrix[row, col] = symbols[currentIndex];
                        currentIndex++;
                    }
                    for (int col = 0; col < columns; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
