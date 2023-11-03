using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
   public class DateModifier
    {
        public decimal DifferenceDates(string first, string second) 
        {
            DateTime firstDate = DateTime.Parse(first);
            DateTime secondDate = DateTime.Parse(second);
            TimeSpan span = firstDate - secondDate;
            return Math.Abs(span.Days);
        }
    }
}
