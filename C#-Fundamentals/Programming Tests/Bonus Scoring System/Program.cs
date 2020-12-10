using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            double MaxBonus = 0;
            int MaxStudentAttendances = 0;
            for (int i = 0; i < studentCount; i++)
            {
                int attendancesForStudent = int.Parse(Console.ReadLine());
                totalBonus = (attendancesForStudent * 1.00 / lecturesCount * 1.00);
                totalBonus *= (5 + bonus);
                if (totalBonus > MaxBonus)
                {
                    MaxBonus = totalBonus;
                    MaxStudentAttendances = attendancesForStudent;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(MaxBonus)}.");
            Console.WriteLine($"The student has attended {MaxStudentAttendances} lectures.");
        }
    }
}
