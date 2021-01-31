using System;

namespace Randomize_Words_Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer randomizer = new StringRandomizer();
            randomizer.array = Console.ReadLine().Split();
            randomizer.Randomise();
            randomizer.PrintWords();
        }
    }
    public class StringRandomizer
    {
        public string[] array;
        public void Randomise()
        {
            Random instance = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int recomposition = instance.Next(0, this.array.Length);
                string temp = this.array[i];
                this.array[i] = this.array[recomposition];
                this.array[recomposition] = temp;
            }
        }
        public void PrintWords()
        {
            Console.WriteLine(String.Join(Environment.NewLine, this.array));
        }
    }
}
