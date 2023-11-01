using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Fashion_Boutique
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            int rackValue = int.Parse(Console.ReadLine());
            int newRacks = rackValue;
            int counterForRack = 1;
            while (clothes.Count > 0)
            {
                if (rackValue >= clothes.Peek())
                {
                    rackValue -= clothes.Pop();
                }
                else if (rackValue < clothes.Peek())
                {
                    rackValue = newRacks;
                    counterForRack++;
                }
            }
            Console.WriteLine(counterForRack);
            Console.Read();
        }
    }
}
