using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int centuries = input * 100;
            int days = (int)(centuries * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{input} centuries = {centuries} years = {days} days " +
                $"= {hours} hours = {minutes} minutes");
        }
    }
}