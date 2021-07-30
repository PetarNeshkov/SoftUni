using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dc = new Dictionary<string, int>();
            string []input = File.ReadAllLines("../../../words.txt");
            string[] text = File.ReadAllText("../../../text.txt")
                .Split(new char[] { ' ', '-', ',', '!','?','.' },StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in input)
            {
                if (!dc.ContainsKey(word))
                {
                    dc.Add(word, 0);
                }
            }
            foreach (var word in text)
            {
                string currWord = word.ToLower();
                if (dc.ContainsKey(currWord))
                {
                    dc[currWord]++;
                }
            }
            using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            {
                foreach (var word in dc.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"{word.Key} -{word.Value}");
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

        }
    }
}
