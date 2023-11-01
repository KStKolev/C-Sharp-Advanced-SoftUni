using System;
using System.Collections.Generic;

namespace P07._Hot_Potato
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] kidNames = Console.ReadLine().Split();
            int timesToToss = int.Parse(Console.ReadLine());
            Queue<string> playingChildren = new Queue<string>(kidNames);
            while (playingChildren.Count > 1)
            {
                for (int i = 0; i < timesToToss; i++)
                {
                    string player = playingChildren.Dequeue();
                    if (i + 1 == timesToToss)
                    {
                        Console.WriteLine($"Removed {player}");
                        continue;
                    }
                    playingChildren.Enqueue(player);
                }
            }
            Console.WriteLine($"Last is {playingChildren.Peek()}");
            Console.Read();
        }
    }
}
