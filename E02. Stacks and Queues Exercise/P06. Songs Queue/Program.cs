using System;
using System.Collections.Generic;

namespace P06._Songs_Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> songsToPlay = new Queue<string>(Console.ReadLine().Split(", "));
            while (songsToPlay.Count > 0)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                if (command.Equals("Play"))
                {
                    songsToPlay.Dequeue();
                }
                else if (command.Equals("Add"))
                {
                    string song = string.Join(" ",commands[1..]);
                    if (!songsToPlay.Contains(song))
                    {
                        songsToPlay.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command.Equals("Show"))
                {
                    Console.WriteLine(string.Join(", ", songsToPlay));
                }
            }
            Console.WriteLine("No more songs!");
            Console.Read();
        }
    }
}
