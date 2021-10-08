using System;

namespace Threeuple
{
  public  class Program
    {
        static void Main(string[] args)
        {
            string[] firstEl = Console.ReadLine().Split();
            string fullName = $"{firstEl[0]} {firstEl[1]}";
            string adress = firstEl[2];
            string town = firstEl[3];
            Threeuple<string, string, string> Tuple1 = new Threeuple<string, string, string>(fullName,adress,town);

            string[] secondEl = Console.ReadLine().Split();
            string name = secondEl[0];
            int liters = int.Parse(secondEl[1]);
            string condition = secondEl[2];
            bool check = Check(condition);
            Threeuple<string, int, bool> Tuple2 = new Threeuple<string, int, bool>(name, liters, check);

            string[] thirdEl = Console.ReadLine().Split();
            string name2 = thirdEl[0];
            double balance = double.Parse(thirdEl[1]);
            string bankName = thirdEl[2];
            Threeuple<string, double, string> Tuple3 = new Threeuple<string, double, string>(name2, balance, bankName);

            Console.WriteLine(Tuple1);
            Console.WriteLine(Tuple2);
            Console.WriteLine(Tuple3);
        }
        public static bool Check(string condition)
        {
            if (condition=="drunk")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
