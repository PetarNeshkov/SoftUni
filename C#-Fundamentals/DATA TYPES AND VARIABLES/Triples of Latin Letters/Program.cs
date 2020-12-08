using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                char firstChar = (char)('a' + i);
                for (int k = 0; k < counter; k++)
                {
                    char secondChar = (char)('a' + k);
                    for (int j = 0; j < counter; j++)
                    {
                        char thirdChar = (char)('a' + j);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
