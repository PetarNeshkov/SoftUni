using System;
using System.Collections.Generic;

namespace CustomStack
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings Stack = new StackOfStrings();
            Console.WriteLine(Stack.IsEmpty());
            string[] array = Console.ReadLine().Split();
            Stack<string> oldStack = new Stack<string>(array);
            Stack.AddRange(oldStack);
            while (Stack.Count!=0)
            {
                Console.WriteLine(Stack.Pop());
            }
        }
    }
}
