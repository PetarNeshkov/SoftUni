using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] tokents = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = tokents[0];
                switch (command)
                {
                    case 1:
                        stack.Push(tokents[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        if (stack.Count>0)
                        {
                            Console.WriteLine(stack.Max());
                        }                
                        break;
                    case 4:
                        if (stack.Count>0)
                        {
                            Console.WriteLine(stack.Min());
                        }            
                        break;
                    default:
                        break;
                }
            }         
                Console.WriteLine(String.Join(", ",stack));
        }
    }
}
