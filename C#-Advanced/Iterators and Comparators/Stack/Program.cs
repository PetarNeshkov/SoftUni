using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Stack<int> stack = new Stack<int>();
            while ((input = Console.ReadLine()) != "END")
            {
                if (input.Contains("Push"))
                {
                    int[] split = input.Split(new string[] { "Push", ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();

                    foreach (var element in split)
                    {
                        stack.Push(element);
                    }
                }
                else if (input == "Pop")
                {
                    stack.Pop();
                }
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
