using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            HashSet<string> hash = new HashSet<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                string[] information = input.Split(",");
                string action = information[0];
                string carNumber = information[1];
                if (action == "IN")
                {
                    if (!hash.Contains(carNumber))
                    {
                        hash.Add(carNumber);
                    }
                }
                else if (action == "OUT")
                {
                    if (hash.Contains(carNumber))
                    {
                        hash.Remove(carNumber);
                    }
                }
            }
            if (hash.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in hash)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
