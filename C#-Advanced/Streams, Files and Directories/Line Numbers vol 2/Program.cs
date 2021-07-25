using System;
using System.IO;
using System.Linq;

namespace Line_Numbers_vol_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");
            string[] newLines = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string currLine = lines[i];
               int letterC= letterCount(currLine);
                int puncC= punctuationCount(currLine);
                 newLines[i] = $"Line {i+1}:{currLine} ({letterC})({puncC})";
                Console.WriteLine(newLines[i] = $"Line {i + 1}:{currLine} ({letterC})({puncC})");
            }
            File.WriteAllLines("../../../output.txt",newLines);
        }
        static int letterCount(string line)
        {

            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]))
                {
                    count++;
                }
            }
            return count;
        }
        static int punctuationCount(string line)
        {
            int count = 0;
            char[] marks = { '.', ',', '!', '?', '-' };
            for (int i = 0; i < line.Length; i++)
            {
                if (marks.Contains(line[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
