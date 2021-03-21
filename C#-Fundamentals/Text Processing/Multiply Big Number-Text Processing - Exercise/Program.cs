using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number_Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            int secondNumber =int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            if (secondNumber==0)
            {
                Console.WriteLine(0);
                return;
            }
            int remainder = 0;
            foreach (var character in firstNumber.Reverse())
            {
                int digit = int.Parse(character.ToString());
                int result = digit * secondNumber+remainder;

                int restDigit = result % 10;
                remainder = result / 10;
                sb.Insert(0, restDigit);
            }
            if (remainder>0)
            {
                sb.Insert(0, remainder);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
