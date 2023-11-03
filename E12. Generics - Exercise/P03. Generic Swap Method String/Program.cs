using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int TimesToLoop = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < TimesToLoop; i++)
            {
                string inputText = Console.ReadLine();
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
