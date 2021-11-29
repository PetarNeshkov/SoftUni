using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfCommands = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            FillMatrix(matrix);

            int startingRow = -1;
            int startingCol = -1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        startingRow = row;
                        startingCol = col;
                    }
                }
            }
            int count = 0;
            bool isWon = false;
            while (count < countOfCommands)
            {
                string input = Console.ReadLine();
                matrix[startingRow, startingCol] = '-';
                switch (input)
                {
                    case "up":
                        if (check(size, input, startingRow, startingCol))
                        {
                            startingRow--;
                        }
                        else
                        {
                            startingRow = size - 1;
                        }

                        if (matrix[startingRow, startingCol] == 'B')
                        {
                            startingRow--;
                        }
                        else if (matrix[startingRow, startingCol] == 'T')
                        {
                            if (startingRow + 1 < size)
                            {
                                startingRow++;
                            }
                            else
                            {
                                startingRow =0;
                            }
                        }

                        if (matrix[startingRow, startingCol] == 'F')
                        {
                            isWon = true;
                        }
                        matrix[startingRow, startingCol] = 'f';
                        break;
                    case "down":
                        if (check(size, input, startingRow, startingCol))
                        {
                            startingRow++;
                        }
                        else
                        {
                            startingRow = 0;
                        }

                        if (matrix[startingRow, startingCol] == 'B')
                        {
                            startingRow++;
                        }
                        else if (matrix[startingRow, startingCol] == 'T')
                        {
                            if (startingRow + 1 < size)
                            {
                                startingRow--;
                            }
                            else
                            {
                                startingRow = size-1;
                            }
                        }

                        if (matrix[startingRow, startingCol] == 'F')
                        {
                            isWon = true;
                        }
                        matrix[startingRow, startingCol] = 'f';
                        break;
                    case "right":
                        if (check(size, input, startingRow, startingCol))
                        {
                            startingCol++;
                        }
                        else
                        {
                            startingCol = 0;
                        }

                        if (matrix[startingRow, startingCol] == 'B')
                        {
                            startingCol++;
                        }
                        else if (matrix[startingRow, startingCol] == 'T')
                        {
                            if (startingRow + 1 < size)
                            {
                                startingCol--;
                            }
                            else
                            {
                                startingCol = size - 1;
                            }
                        }

                        if (matrix[startingRow, startingCol] == 'F')
                        {
                            isWon = true;
                        }
                        matrix[startingRow, startingCol] = 'f';
                        break;
                    case "left":
                        if (check(size, input, startingRow, startingCol))
                        {
                            startingCol--;
                        }
                        else
                        {
                            startingCol = size-1;
                        }

                        if (matrix[startingRow, startingCol] == 'B')
                        {
                            if (startingCol - 1 >= 0)
                            {
                                startingCol--;
                            }
                            else
                            {
                                startingCol = size-1;
                            }
                        }
                        else if (matrix[startingRow, startingCol] == 'T')
                        {
                            if (startingRow + 1 < size)
                            {
                                startingCol++;
                            }
                            else
                            {
                                startingCol =0;
                            }
                        }

                        if (matrix[startingRow, startingCol] == 'F')
                        {
                            isWon = true;
                        }
                        matrix[startingRow, startingCol] = 'f';
                        break;

                }
                if (isWon)
                {
                    break;
                }
                count++;
            }
            if (isWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            PrintMatrix(matrix);
        }
        static void FillMatrix(char[,] matrix)
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
        static bool check(int size, string direction, int row, int col)
        {
            if (direction == "up")
            {
                if (row - 1 >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (direction == "down")
            {
                if (row + 1 < size)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (direction == "left")
            {
                if (col - 1 >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (direction == "right")
            {
                if (col + 1 < size)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        static void PrintMatrix(char[,] matrix)
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
