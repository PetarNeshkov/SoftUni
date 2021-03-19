using System;
using System.Text;

namespace Caesar_Cipher_Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder newText = new StringBuilder();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                newText.Append((char)(text[i] + 3));
            }
            Console.WriteLine(newText);
        }
    }
}
