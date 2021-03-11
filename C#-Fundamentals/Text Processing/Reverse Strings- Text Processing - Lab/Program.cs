using System;
using System.Text;

namespace Reverse_Strings__Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string input = " ";
            while ((input=Console.ReadLine())!="end")
            {
                StringBuilder newString = new StringBuilder();
                for (int i = input.Length-1; i >= 0; i--)
                {
                    newString.Append(input[i]);
                }
                Console.WriteLine($"{input} = {newString}");
            }
        }
    }
}
