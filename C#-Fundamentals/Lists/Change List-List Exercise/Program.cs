using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List_List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Elements = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="end")
            {
                string[] commands = input.Split();
                string action = commands[0];
                int elemements = int.Parse(commands[1]);
                if (action=="Delete")
                {
                    for (int i = 0; i < Elements.Count; i++)
                    {
                       
                            Elements.Remove(elemements);
                        
                    }
                }
                else if (action=="Insert")
                {
                    int position = int.Parse(commands[2]);
                   
                        Elements.Insert(position, elemements);
                    
                }
            }
            Console.WriteLine(String.Join(" ",Elements));
        }
    }
}
