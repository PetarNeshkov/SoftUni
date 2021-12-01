using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            FillMatrix(matrix);

            int startRow = -1;
            int startCol = -1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            int foodCount = 0;
            string command;
            while (true)
            {
                command = Console.ReadLine();
                    matrix[startRow, startCol] = '.';
                if (Check(size, command, startRow, startCol))
                {
                    switch (command)
                    {
                        case "up":
                            startRow--;
                            if (matrix[startRow, startCol] == '*')
                            {
                                foodCount++;
                            }
                            else if (matrix[startRow, startCol] == 'B')
                            {
                                matrix[startRow, startCol] = '.';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'B')
                                        {
                                            startRow = row;
                                            startCol = col;
                                        }
                                    }
                                }
                            }
                            break;
                        case "down":
                            startRow++;
                            if (matrix[startRow, startCol] == '*')
                            {
                                foodCount++;
                            }
                            else if (matrix[startRow, startCol] == 'B')
                            {
                                matrix[startRow, startCol] = '.';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'B')
                                        {
                                            startRow = row;
                                            startCol = col;
                                        }
                                    }
                                }
                            }
                            break;
                        case "left":
                            startCol--;
                            if (matrix[startRow, startCol] == '*')
                            {
                                foodCount++;
                            }
                            else if (matrix[startRow, startCol] == 'B')
                            {
                                matrix[startRow, startCol] = '.';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'B')
                                        {
                                            startRow = row;
                                            startCol = col;
                                        }
                                    }
                                }
                            }
                            break;
                        case "right":
                            startCol++;
                            if (matrix[startRow, startCol] == '*')
                            {
                                foodCount++;
                            }
                            else if (matrix[startRow, startCol] == 'B')
                            {
                                matrix[startRow, startCol] = '.';
                                for (int row = 0; row < matrix.GetLength(0); row++)
                                {
                                    for (int col = 0; col < matrix.GetLength(1); col++)
                                    {
                                        if (matrix[row, col] == 'B')
                                        {
                                            startRow = row;
                                            startCol = col;
                                        }
                                    }
                                }
                            }
                            break;
                    }
                    matrix[startRow, startCol] = 'S';
                    if (foodCount >= 10)
                    {
                        Console.WriteLine("You won! You fed the snake.");
                        Console.WriteLine($"Food eaten: {foodCount}");
                        PrintMatrix(matrix);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Food eaten: {foodCount}");
                    PrintMatrix(matrix);
                    return;
                }
            }

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
