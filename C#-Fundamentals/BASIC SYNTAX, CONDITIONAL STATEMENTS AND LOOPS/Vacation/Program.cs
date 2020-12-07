using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupOfPeople = int.Parse(Console.ReadLine());
            string TypeOfTicket = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (day == "Friday")
            {
                if (TypeOfTicket == "Students")
                {
                    if (groupOfPeople >= 30)
                    {
                        price = 8.45 * groupOfPeople - (8.45 * groupOfPeople) * 0.15;
                    }
                    else
                    {
                        price = 8.45 * groupOfPeople;
                    }
                }
                else if (TypeOfTicket == "Business")
                {
                    if (groupOfPeople >= 100)
                    {
                        price = 10.90 * groupOfPeople - 8.45 * 10;
                    }
                    else
                    {
                        price = 10.90 * groupOfPeople;
                    }
                }
                else if (TypeOfTicket == "Regular")
                {
                    if (groupOfPeople >= 10 && groupOfPeople <= 20)
                    {
                        price = 15 * groupOfPeople - (15 * groupOfPeople) * 0.05;
                    }
                    else
                    {
                        price = 15 * groupOfPeople;
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (TypeOfTicket == "Students")
                {
                    if (groupOfPeople >= 30)
                    {
                        price = 9.80 * groupOfPeople - (9.80 * groupOfPeople) * 0.15;
                    }
                    else
                    {
                        price = 9.80 * groupOfPeople;
                    }
                }
                else if (TypeOfTicket == "Business")
                {
                    if (groupOfPeople >= 100)
                    {
                        price = 15.60 * groupOfPeople - 15.60 * 10;
                    }
                    else
                    {
                        price = 15.60 * groupOfPeople;
                    }
                }
                else if (TypeOfTicket == "Regular")
                {
                    if (groupOfPeople >= 10 && groupOfPeople <= 20)
                    {
                        price = 20 * groupOfPeople - (20 * groupOfPeople) * 0.05;
                    }
                    else
                    {
                        price = 20 * groupOfPeople;
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (TypeOfTicket == "Students")
                {
                    if (groupOfPeople >= 30)
                    {
                        price = 10.46 * groupOfPeople - (10.46 * groupOfPeople) * 0.15;
                    }
                    else
                    {
                        price = 10.46 * groupOfPeople;
                    }
                }
                else if (TypeOfTicket == "Business")
                {
                    if (groupOfPeople >= 100)
                    {
                        price = 16 * groupOfPeople - 16 * 10;
                    }
                    else
                    {
                        price = 16 * groupOfPeople;
                    }
                }
                else if (TypeOfTicket == "Regular")
                {
                    if (groupOfPeople >= 10 && groupOfPeople <= 20)
                    {
                        price = 22.50 * groupOfPeople - (22.50 * groupOfPeople) * 0.05;
                    }
                    else
                    {
                        price = 22.50 * groupOfPeople;
                    }
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}