using System;
using System.Collections.Generic;

namespace P08._SoftUni_Party
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> vipMembers = new HashSet<string>();
            HashSet<string> regularMembers = new HashSet<string>();
            string inputCommand = string.Empty;
            bool isOver = false;
            while ((inputCommand = Console.ReadLine()) != "END")
            {
                if (inputCommand != "PARTY")
                {
                    int firstNumber = 0;
                    string firstSymbol = inputCommand[0].ToString();
                    bool isNumber = int.TryParse(firstSymbol, out firstNumber);
                    if (isNumber == true)
                    {
                        vipMembers.Add(inputCommand);
                    }
                    else
                    {
                        regularMembers.Add(inputCommand);
                    }
                }
                else
                {
                    while (true)
                    {
                        string partyMembers = Console.ReadLine();
                        if (partyMembers.Equals("END"))
                        {
                            isOver = true;
                            break;
                        }
                        if (vipMembers.Contains(partyMembers))
                        {
                            vipMembers.Remove(partyMembers);
                        }
                        else
                        {
                            regularMembers.Remove(partyMembers);
                        }
                    }
                }
                if (isOver == true)
                {
                    break;
                }
            }
            if (vipMembers.Count == 0 && regularMembers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int count = vipMembers.Count + regularMembers.Count;
                Console.WriteLine(count);
                if (vipMembers.Count > 0 && regularMembers.Count > 0)
                {
                    foreach (var currentVIP in vipMembers)
                    {
                        Console.WriteLine(currentVIP);
                    }
                    foreach (var currentRegular in regularMembers)
                    {
                        Console.WriteLine(currentRegular);
                    }
                }
                else if (vipMembers.Count > 0 && regularMembers.Count == 0)
                {
                    foreach (var currentVIP in vipMembers)
                    {
                        Console.WriteLine(currentVIP);
                    }
                }
                else if (vipMembers.Count == 0 && regularMembers.Count > 0)
                {
                    foreach (var currentRegular in regularMembers)
                    {
                        Console.WriteLine(currentRegular);
                    }
                }
            }
            Console.Read();
        }
    }
}
