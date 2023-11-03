using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int result = x.CompareTo(y);
            if (result == 0)
            {
                result = y.CompareTo(x);
            }
            return result;
        }
    }
}
