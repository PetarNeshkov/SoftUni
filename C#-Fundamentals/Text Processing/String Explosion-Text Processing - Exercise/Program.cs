using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string List = Console.ReadLine();
            int bombpower = 0;
            int newBomb = 0;
            bool bomb = false;
            for (int i = 0; i < List.Length; i++)
            {
                char currentLetter = List[i];
                if (bomb)
                {
                    newBomb = int.Parse(List[i].ToString());
                    bombpower += newBomb;
                }
                if (currentLetter == '>')
                {
                    bomb = true;
                }
                else bomb = false;
                if (List[i] != '>' && bombpower > 0)
                {
                    List = List.Remove(i, 1);
                    bombpower--;           
                    i--;
                }
            }
            Console.WriteLine(List);
        }
    }
}

