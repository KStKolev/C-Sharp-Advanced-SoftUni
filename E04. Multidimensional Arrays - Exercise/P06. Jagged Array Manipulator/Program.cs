using System;
using System.Linq;

namespace P06._Jagged_Array_Manipulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[numberOfRows][];
            for (int row = 0; row < numberOfRows; row++)
            {
                int[] column = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jaggedArray[row] = new int[column.Length];
                for (int col = 0; col < column.Length; col++)
                {
                    jaggedArray[row][col] = column[col];
                }
            }
            for (int row = 0; row < numberOfRows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                    }
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row+1].Length; col++)
                    {
                        jaggedArray[row+1][col] /= 2;
                    }
                }
            }
            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "End")
            {
                string[] commands = inputCommand.Split();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int column = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (row >= 0 && column >= 0)
                {
                    if (row <= numberOfRows && column <= jaggedArray[row].Length - 1)
                    {
                        if (command.Equals("Add"))
                        {
                            jaggedArray[row][column] += value;
                        }
                        else
                        {
                            jaggedArray[row][column] -= value;
                        }
                    }
                }
            }
            foreach (int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            Console.Read();
        }
    }
}
