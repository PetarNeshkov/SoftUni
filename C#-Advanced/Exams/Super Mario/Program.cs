using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class StartUp
    {
        static void Main()
        {
            double health = double.Parse(Console.ReadLine());
            int rowSize = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rowSize][];

            int rowStart = 0;
            int colStart = 0;

            FillMatrix3(matrix, rowSize, ref rowStart, ref colStart);


            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string direction = input[0].ToUpper();
                int rowEnemy = int.Parse(input[1]);
                int colEnemy = int.Parse(input[2]);


                matrix[rowEnemy][colEnemy] = 'B';


                if (Check(rowSize, direction, rowStart, colStart))
                {
                    matrix[rowStart][colStart] = '-';

                    health--;
                    rowStart = MoveRow(rowStart, direction);
                    colStart = MoveCol(colStart, direction);

                    if (matrix[rowStart][colStart] == 'B')
                    {
                        health -= 2;
                    }
                    else if (matrix[rowStart][colStart] == 'P')
                    {
                        matrix[rowStart][colStart] = '-';
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                        PrintMatrix2(matrix);
                        return;
                    }

                }
                else
                {
                    health--;
                }
                if (health <= 0)
                {
                    matrix[rowStart][colStart] = 'X';
                    Console.WriteLine($"Mario died at {rowStart};{colStart}.");
                    PrintMatrix2(matrix);
                    return;
                }
                matrix[rowStart][colStart] = 'M';
            }
        }
        private static bool Check(int size, string currMove, int currRow, int currCol)
        {
            if (currMove == "W")
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
            else if (currMove == "S")
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
            else if (currMove == "A")
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
            else if (currMove == "D")
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
        private static bool Check2(int size, string currMove, int currRow, int currCol)
        {
            if (currMove == "W")
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
            else if (currMove == "S")
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
            else if (currMove == "A")
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
            else if (currMove == "D")
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
        private static bool CheckSize(int size, int currRow, int currCol)
        {
            if ((currRow >= 0 && currRow < size) && (currCol >= 0 && currCol < size))
            {
                return true;
            }
            return false;
        }
        private static bool CheckSize2(int rowSize, int colSize, int currRow, int currCol)
        {
            if ((currRow >= 0 && currRow < rowSize) && (currCol >= 0 && currCol < colSize))
            {
                return true;
            }
            return false;
        }

        private static void FillMatrix(char[,] matrix, ref int rowStart, ref int colStart)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                //char[] rowData = Console
                //                   .ReadLine()
                //                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                //                   .Select(char.Parse)
                //                   .ToArray();
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (rowData[col] == 'M')
                    {
                        rowStart = row;
                        colStart = col;
                    }
                    matrix[row, col] = rowData[col];
                }
            }
        }
        private static void FillMatrix3(char[][] matrix, int rowSize, ref int rowStart, ref int colStart)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                //char[] rowData = Console
                //                   .ReadLine()
                //                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                //                   .Select(char.Parse)
                //                   .ToArray();
                matrix[row] = new char[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    if (rowData[col] == 'M')
                    {
                        rowStart = row;
                        colStart = col;
                    }
                    matrix[row][col] = rowData[col];
                }
            }
        }
        private static void FillMatrix2(char[,] matrix, ref int firstPlayer, ref int secondPlayer)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //char[] rowData = Console.ReadLine().ToCharArray();
                char[] rowData = Console
                                   .ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(char.Parse)
                                   .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (rowData[col] == '<')
                    {
                        firstPlayer++;
                    }
                    else if (rowData[col] == '>')
                    {
                        secondPlayer++;
                    }
                }
            }
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        private static void PrintMatrix2(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
        private static int MoveRow(int row, string movement)
        {
            if (movement == "W")
            {
                return row - 1;
            }
            if (movement == "S")
            {
                return row + 1;
            }

            return row;
        }
        private static int MoveCol(int col, string movement)
        {
            if (movement == "A")
            {
                return col - 1;
            }
            if (movement == "D")
            {
                return col + 1;
            }

            return col;
        }
    }
}