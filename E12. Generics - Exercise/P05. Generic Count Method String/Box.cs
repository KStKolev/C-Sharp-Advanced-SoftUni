using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> strings;

        public Box()
        {
            strings = new List<T>();
        }

        public void AddString(T element)
        {
            strings.Add(element);
        }

        public void SwapElements(int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < strings.Count && secondIndex >= 0 && secondIndex < strings.Count)
            {
                T replacedString = strings[firstIndex];
                strings[firstIndex] = strings[secondIndex];
                strings[secondIndex] = replacedString;
            }
        }

        public int CompareCount(T element)
        {
            int count = 0;
            foreach (var currentElement in strings)
            {
                if (currentElement.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (T currentString in strings)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {currentString}");
            }
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
