using System;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                using (StreamReader reader = new StreamReader("../../../input.txt"))
                {
                    string line = reader.ReadLine();
                    int index = 0;
                    while (line != null)
                    {
                        if (index % 2 == 1)
                        {
                            Console.WriteLine(line);
                            writer.WriteLine(line);
                        }
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
