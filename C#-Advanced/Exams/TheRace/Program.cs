using ConsoleApp1;
using System;
using System.Linq;

namespace TheRace
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Initialize the repository
            Race race = new Race("Indianapolis 500", 10);

            //Initialzie cars
            Car car1 = new Car("ferrari", 150);
            Car car2 = new Car("lambo", 170);

            //Initialize racer1
            Racer racer1 = new Racer("Stephen", 40, "Bulgaria", car1);

            //Print Racer
            Console.WriteLine(racer1); //Racer: Stephen, 40 (Bulgaria)

            //Add Racer
            race.Add(racer1);
            //Remove Racer
            race.Remove("Vin Benzin"); //false

            Racer racer2 = new Racer("Mark", 34, "UK", car2);

            //Add Racer
            race.Add(racer2);

            Racer oldestRacer = race.GetOldestRacer(); // Racer with name Stephen
            Racer racerStephen = race.GetRacer("Stephen"); // Racer with name Stephen
            Racer fastestRacer = race.GetFastestRacer(); // Racer with name Mark

            Console.WriteLine(oldestRacer); //Racer: Stephen, 40 (Bulgaria)
            Console.WriteLine(racerStephen); //Racer: Stephen, 40 (Bulgaria)
            Console.WriteLine(fastestRacer); // Racer: Mark, 34 (UK)
            Console.WriteLine(race.Count); //2

            Console.WriteLine(race.Report());
            //Racers working at Indianapolis 500:
            //Racer: Stephen, 40 (Bulgaria)
            //Racer: Mark, 34 (UK)

        }
        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }
        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }
        private static bool Check(int size, string currMove, int currRow, int currCol)
        {
            if (currMove == "up")
            {
                if (currRow - 1 >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (currMove == "down")
            {
                if (currRow + 1 < size)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (currMove == "left")
            {
                if (currCol - 1 >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (currMove == "right")
            {
                if (currCol + 1 < size)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

