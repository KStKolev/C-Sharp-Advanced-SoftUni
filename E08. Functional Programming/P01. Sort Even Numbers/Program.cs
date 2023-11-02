namespace P01._Sort_Even_Numbers
{
    using System;
    using System.Linq;
   public class Program
    {
       public static void Main(string[] args)
        {
            int[] sortedEvenNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(IsEven)
                .OrderBy(x => x)
                .ToArray();
            Console.WriteLine(string.Join(", ", sortedEvenNumbers));
            Console.Read();

            bool IsEven(int number) 
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
