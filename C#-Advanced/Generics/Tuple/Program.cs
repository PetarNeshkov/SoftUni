using System;

namespace Tuple
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string FullName = $"{firstInput[0]} {firstInput[1]}";
            string adress = firstInput[2];
            Tuple<string,string> Tuple1 = new Tuple<string,string>(FullName,adress);

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersOfBeer = int.Parse(secondInput[1]);
            Tuple<string, int> Tuple2 = new Tuple<string, int>(name, litersOfBeer);

            string[] thirdInput = Console.ReadLine().Split();
            int intNum = int.Parse(thirdInput[0]);
            double doubleNum = double.Parse(thirdInput[1]);
            Tuple<int, double> Tuple3 = new Tuple<int, double>(intNum, doubleNum);

            Console.WriteLine(Tuple1);
            Console.WriteLine(Tuple2);
            Console.WriteLine(Tuple3);
        }
    }
}
