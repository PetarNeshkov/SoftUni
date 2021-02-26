using System;
using System.Collections.Generic;

namespace Word_Synonyms_Associative_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();
            for (int i = 0; i < counter; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (collection.ContainsKey(word))
                {
                    collection[word].Add(synonym);
                }
                else
                {
                    collection.Add(word, new List<string>());
                    collection[word].Add(synonym);
                }
            }
            foreach (var item in collection)
            {
                Console.WriteLine(item.Key+" - "+String.Join(", ",item.Value) );
            }
        }
    }
}
