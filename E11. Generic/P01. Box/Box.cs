using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private int count;
        private List<T> elements;

        public Box()
        {
            elements = new List<T>();
        }

        public int Count { get { return this.count; } }

        public void Add(T element) 
        {
            elements.Add(element);
            count++;
        }

        public T Remove() 
        {
            count--;
            T removedElement = elements.Last();
            elements.RemoveAt(count);
            return removedElement;
        }
    }
}
