using System;

namespace Orders__Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOforder = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Orders(nameOforder,quantity);
        }
        static void Orders(string nameOforder,int quantity)
        {
            double sum = 0;
            switch (nameOforder)
            {
                case "water":
                    sum = 1.00 * quantity;
                    break;
                case "coffee":
                    sum = 1.50 * quantity;
                    break;
                case "coke":
                    sum = 1.40 * quantity;
                    break;
                case "snacks":
                    sum = 2.00 * quantity;
                    break;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
