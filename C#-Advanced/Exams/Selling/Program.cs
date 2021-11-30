using System;
using System.Collections.Generic;
using System.Linq;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            FillMatrix(matrix);
            int currRow = -1;
            int currCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }
            int sum = 0;
            while (sum < 50)
            {
                string input = Console.ReadLine();
                 matrix[currRow, currCol] = '-';
                switch (input)
                {
                    case "up":
                        if (check(size, input, currRow, currCol))
                        {
                             currRow= currRow -1;
                            if (char.IsDigit(matrix[currRow,currCol]))
                            {
                                int digit = int.Parse(matrix[currRow, currCol].ToString());
                                sum += digit;
                            }
                            else if (matrix[currRow, currCol] =='O')
                            {
                                matrix[currRow, currCol] = '-';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'O')
                                        {
                                            currRow = row;
                                            currCol = col;
                                        }
                                    }
                                }
                            }
                            matrix[currRow, currCol] = 'S';
                        }
                        else
                        {
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            Console.WriteLine($"Money: {sum}");
                            PrintMatrix(matrix);
                            return;
                        }
                        break;
                    case "down":
                        if (check(size, input, currRow, currCol))
                        {
                            currRow = currRow + 1;
                            if (char.IsDigit(matrix[currRow, currCol]))
                            {
                                int digit = int.Parse(matrix[currRow, currCol].ToString());
                                sum += digit;
                            }
                            else if (matrix[currRow, currCol] == 'O')
                            {
                                matrix[currRow, currCol] = '-';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'O')
                                        {
                                            currRow = row;
                                            currCol = col;
                                        }
                                    }
                                }
                            }
                            matrix[currRow, currCol] = 'S';
                        }
                        else
                        {
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            Console.WriteLine($"Money: {sum}");
                            PrintMatrix(matrix);
                            return;
                        }
                        break;
                    case "left":
                        if (check(size, input, currRow, currCol))
                        {
                            currCol = currCol - 1;
                            if (char.IsDigit(matrix[currRow, currCol]))
                            {
                                int digit = int.Parse(matrix[currRow, currCol].ToString());
                                sum += digit;
                            }
                            else if (matrix[currRow, currCol] == 'O')
                            {
                                matrix[currRow, currCol] = '-';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'O')
                                        {
                                            currRow = row;
                                            currCol = col;
                                        }
                                    }
                                }
                            }
                            matrix[currRow, currCol] = 'S';
                        }
                        else
                        {
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            Console.WriteLine($"Money: {sum}");
                            PrintMatrix(matrix);
                            return;
                        }
                        break;
                    case "right":
                        if (check(size, input, currRow, currCol))
                        {
                            currCol = currCol + 1;
                            if (char.IsDigit(matrix[currRow, currCol]))
                            {
                                int digit =int.Parse(matrix[currRow, currCol].ToString());
                                sum += digit;
                            }
                            else if (matrix[currRow, currCol] == 'O')
                            {
                                matrix[currRow, currCol] = '-';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'O')
                                        {
                                                currRow = row;
                                                currCol = col;     
                                        }
                                    }
                                }
                            }
                            matrix[currRow, currCol] = 'S';
                        }
                        else
                        {
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            Console.WriteLine($"Money: {sum}");
                            PrintMatrix(matrix);
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Good news! You succeeded in collecting enough money!");
            Console.WriteLine($"Money: {sum}");
            PrintMatrix(matrix);
        }
        public static void FillMatrix(char[,] matrix)
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
        public static void PrintMatrix(char[,]matrix)
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
