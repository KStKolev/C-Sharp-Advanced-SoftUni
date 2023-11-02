namespace LineNumbers
{
    using System.IO;
    using System.Linq;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadLines(inputFilePath).ToArray();
            string[] newLines = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = 0;
                int punctuationCount = 0;
                foreach (var currentSymbols in lines[i])
                {
                    if (char.IsLetter(currentSymbols))
                    {
                        letterCount++;
                    }
                    else if (char.IsPunctuation(currentSymbols))
                    {
                        punctuationCount++;
                    }
                }
                newLines[i] = $"Line {i + 1}: {lines[i]} ({letterCount})({punctuationCount})";
            }
            File.WriteAllLines(outputFilePath, newLines);
        }
    }
}
