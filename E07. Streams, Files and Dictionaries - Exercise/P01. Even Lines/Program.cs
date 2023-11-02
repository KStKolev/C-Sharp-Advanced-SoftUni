namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
            Console.Read();
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder endLines = new StringBuilder();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (count % 2 == 0)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (char.IsPunctuation(line[i]) && line[i] != '@')
                            {
                                line = line.Replace(line[i], '@');
                            }
                        }
                        string[] reversedWords = line
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Reverse()
                            .ToArray();
                        endLines.AppendLine(string.Join(" ", reversedWords));
                    }
                    count++;
                }
            }
            return endLines.ToString().TrimEnd();
        }
    }
}
