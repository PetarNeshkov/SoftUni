using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double number = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var currentString = array[i];

                var firstLetter = currentString[0];
                var lastLetter = currentString[currentString.Length - 1];
                number = double.Parse(currentString.Substring(1, currentString.Length - 2));


                int beforeNumberPosition = char.Parse(firstLetter.ToString().ToUpper()) - 64;
                int afterNumberPosition = char.Parse(lastLetter.ToString().ToUpper()) - 64;

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number /= beforeNumberPosition;
                }
                else
                {
                    number *= beforeNumberPosition;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number -= afterNumberPosition;
                }
                else
                {
                    number += afterNumberPosition;
                }
                sum += number;
            }
            Console.WriteLine($"{sum:F2}");

        }
    }
}

