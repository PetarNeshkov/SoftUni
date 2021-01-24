using System;
using System.Collections.Generic;

namespace House_Party_List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<string> HouseParty = new List<string>();
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] names = Console.ReadLine().Split();
                string name = names[0];
                if (names[2] != "not")
                {
                    if (!HouseParty.Contains(name))
                    {
                        HouseParty.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (!HouseParty.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        HouseParty.Remove(name);
                    }
                }
            }
            foreach (var item in HouseParty)
            {
                Console.WriteLine(item);
            }
        }
    }
}
