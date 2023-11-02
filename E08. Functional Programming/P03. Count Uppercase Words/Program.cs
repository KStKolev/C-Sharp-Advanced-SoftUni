namespace P03._Count_Uppercase_Words
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Predicate<string> wantedWords = w => w[0] == w.ToUpper()[0];
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => wantedWords(x)).ToArray();
            foreach (var currentWord in text)
            {
                Console.WriteLine(currentWord);
            }
            Console.Read();
            
        }
    }
}
