using System;
using System.Linq;

namespace P07._Pascal_Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[rows][];
            int currentColumns = 1;
            for (long row = 0; row < rows; row++)
            {
                jaggedArray[row] = new long[currentColumns];
                long[] currentRow = jaggedArray[row];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentColumns++;
                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = jaggedArray[row - 1];
                        long previousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = previousRowSum;
                    }
                }
            }
            foreach (long[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            Console.Read();
        }
    }
}
