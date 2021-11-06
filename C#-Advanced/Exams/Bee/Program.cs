using System;
using System.Linq;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            FillMatrix(matrix);
            int rowBee = -1;
            int colBee = -1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        rowBee = row;
                        colBee = col;
                    }
                }
            }
            string input;
            int pollinatedFlowers = 0;
            bool exit = false;
            while ((input = Console.ReadLine()) != "End")
            {
                matrix[rowBee, colBee] = '.';
                switch (input)
                {
                    case "up":
                        if (check(n, input, rowBee, colBee))
                        {
                            rowBee--;
                            if (matrix[rowBee, colBee] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                            else if (matrix[rowBee, colBee] == 'O')
                            {
                                matrix[rowBee, colBee] = '.';
                                rowBee--;
                                if (matrix[rowBee, colBee] == 'f')
                                {
                                    pollinatedFlowers++;
                                }
                            }
                            matrix[rowBee, colBee] = 'B';
                        }
                        else
                        {
                            matrix[rowBee, colBee] = '.';
                            Console.WriteLine("The bee got lost!");
                            exit = true;
                            break;
                        }
                        break;
                    case "down":
                        if (check(n, input, rowBee, colBee))
                        {
                            matrix[rowBee, colBee] = '.';
                            rowBee++;
                            if (matrix[rowBee, colBee] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                            else if (matrix[rowBee, colBee] == 'O')
                            {
                                matrix[rowBee, colBee] = '.';
                                rowBee++;
                                if (matrix[rowBee, colBee] == 'f')
                                {
                                    pollinatedFlowers++;
                                }
                            }
                            matrix[rowBee, colBee] = 'B';
                        }
                        else
                        {
                            matrix[rowBee, colBee] = '.';
                            Console.WriteLine("The bee got lost!");
                            exit = true;
                            break;
                        }
                        break;
                    case "left":
                        if (check(n, input, rowBee, colBee))
                        {
                            colBee--;
                            if (matrix[rowBee, colBee] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                            else if (matrix[rowBee, colBee] == 'O')
                            {
                                matrix[rowBee, colBee] = '.';
                                colBee--;
                                if (matrix[rowBee, colBee] == 'f')
                                {
                                    pollinatedFlowers++;
                                }
                            }
                            matrix[rowBee, colBee] = 'B';

                        }
                        else
                        {
                            matrix[rowBee, colBee] = '.';
                            Console.WriteLine("The bee got lost!");
                            exit = true;
                            break;
                        }
                        break;
                    case "right":
                        if (check(n, input, rowBee, colBee))
                        {
                            colBee++;
                            if (matrix[rowBee, colBee] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                            else if (matrix[rowBee, colBee] == 'O')
                            {
                                matrix[rowBee, colBee] = '.';
                                colBee++;
                                if (matrix[rowBee, colBee] == 'f')
                                {
                                    pollinatedFlowers++;
                                }
                            }
                            matrix[rowBee, colBee] = 'B';
                        }
                        else
                        {
                            matrix[rowBee, colBee] = '.';
                            Console.WriteLine("The bee got lost!");
                            exit = true;
                            break;
                        }
                        break;
                }
                if (exit)
                {
                    break;
                }
            }
            if (pollinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            PrintMatrix(matrix);
        }
        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
        private static bool check(int size, string currMove, int currRow, int currCol)
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
    }
}
