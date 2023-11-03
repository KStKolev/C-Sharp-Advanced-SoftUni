using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofInteger
{
    public class Box<T>
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
