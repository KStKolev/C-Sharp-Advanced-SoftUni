namespace P02._Sum_Numbers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int countOfArray = CountArray(numberArray);
            int sumOfArray = SumArray(numberArray);
            Console.WriteLine(countOfArray);
            Console.WriteLine(sumOfArray);
            Console.Read();

            int CountArray(int[] numberArray) 
            {
                int counter = 0;
                foreach (var item in numberArray)
                {
                    counter++;
                }
                return counter;
            }
            int SumArray(int[] numberArray) 
            {
                int result = 0;
                foreach (var number in numberArray)
                {
                    result += number;
                }
                return result;
            }
        }
    }
}
