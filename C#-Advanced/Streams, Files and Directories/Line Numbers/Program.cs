using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamWriter writer=new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    int index = 1;
                    while (line!=null)
                    {
                        writer.WriteLine($"{index}. {line}line");
                        Console.WriteLine($"{index}. {line}line");
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
