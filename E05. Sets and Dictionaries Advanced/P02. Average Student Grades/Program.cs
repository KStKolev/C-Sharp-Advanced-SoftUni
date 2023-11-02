using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Average_Student_Grades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < timesToLoop; i++)
            {
                string[] studentGrade = Console.ReadLine().Split();
                string name = studentGrade[0];
                decimal grade = decimal.Parse(studentGrade[1]);
                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }
            foreach (var keyValuePair in studentGrades)
            {
                Console.Write($"{keyValuePair.Key} -> ");
                foreach (var currentValue in keyValuePair.Value)
                {
                    Console.Write($"{currentValue:F2} ");
                }
                Console.Write($"(avg: {keyValuePair.Value.Average():F2})");
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
