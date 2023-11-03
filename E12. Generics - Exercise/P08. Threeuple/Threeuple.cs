using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomThreeuple
{
    public class Threeuple<T,V,U>
    {
        private T item1;
        private V item2;
        private U item3;

        public Threeuple(T item1, V item2, U item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        public T Item1 { get => item1; private set => item1 = value; }
        public V Item2 { get => item2; private set => item2 = value; }
        public U Item3 { get => item3; private set => item3 = value; }

        public override string ToString()
        {
            return string.Format($"{Item1} -> {Item2} -> {Item3}");
        }
    }
}
