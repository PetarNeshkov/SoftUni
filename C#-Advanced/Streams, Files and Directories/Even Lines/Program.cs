using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("[-,.!?]");
            using StreamReader reader = new StreamReader("../../../text.txt");
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    int counter = 0;
                    while (line != null)
                    {
                        if (counter % 2 == 0)
                        {
                            line = pattern.Replace(line, "@");
                            string[] array = line.Split().Reverse().ToArray();
                            writer.WriteLine(String.Join(" ", array));
                            Console.WriteLine(String.Join(" ", array));
                        }
                        line = reader.ReadLine();
                        counter++;
                    }

                }
            }
        }
    }
}
