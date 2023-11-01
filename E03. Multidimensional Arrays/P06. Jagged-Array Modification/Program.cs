using System;
using System.Linq;

namespace P06._Jagged_Array_Modification
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] column = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                jaggedArray[row] = new int[column.Length];
                for (int col = 0; col < column.Length; col++)
                {
                    jaggedArray[row][col] = column[col];
                }
            }
            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "END")
            {
                string[] commands = inputCommand.Split();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int column = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (command.Equals("Add"))
                {
                    if (row < 0 || row >= jaggedArray.Length || column < 0 || column > jaggedArray.Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jaggedArray[row][column] += value;
                    }
                }
                else if (command.Equals("Subtract"))
                {
                    if (row < 0 || row >= jaggedArray.Length || column < 0 || column > jaggedArray.Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jaggedArray[row][column] -= value;
                    }
                }
            }
            foreach (int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join($" ", row));
            }
            Console.Read();
        }
    }
}
