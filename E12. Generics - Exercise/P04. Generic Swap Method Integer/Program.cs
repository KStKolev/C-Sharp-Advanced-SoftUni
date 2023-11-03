using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int TimesToLoop = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < TimesToLoop; i++)
            {
                int inputText = int.Parse(Console.ReadLine());
                box.AddString(inputText);
            }
            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            box.SwapElements(indexes[0], indexes[1]);
            Console.WriteLine(box.ToString());
            Console.Read();
        }
    }
}
