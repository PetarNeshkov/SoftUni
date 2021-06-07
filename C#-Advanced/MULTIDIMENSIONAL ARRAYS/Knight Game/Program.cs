using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            fillMatrix(matrix);
            int counter = 0;
            while (true)
            {
                int maxAttackedKnights = 0;
                int BestRow = -1;
                int BestCol = -1;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currChar = matrix[row, col];
                        if (currChar == 'K')
                        {
                            int currKnights = countAttacks(matrix, row, col);
                            if (currKnights > maxAttackedKnights)
                            {
                                maxAttackedKnights = currKnights;
                                BestRow = row;
                                BestCol = col;
                            }
                        }
                    }
                }
                if (maxAttackedKnights == 0)
                {
                    break;
                }
                matrix[BestRow, BestCol] = '0';
                counter++;
            }
            Console.WriteLine(counter);
        }

        private static int countAttacks(char[,] matrix, int row, int col)
        {
            int count = 0;
            int maxLenght = matrix.GetLength(0);
            //up
            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
            {
                count++;
            }
            if (row - 1 >= 0 && col + 2 < maxLenght && matrix[row - 1, col + 2] == 'K')
            {
                count++;
            }
            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
            {
                count++;
            }
            if (row - 2 >= 0 && col + 1 < maxLenght && matrix[row - 2, col + 1] == 'K')
            {
                count++;
            }

            //down
            if (row + 1 < maxLenght && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
            {
                count++;
            }
            if (row + 1 < maxLenght && col + 2 < maxLenght && matrix[row + 1, col + 2] == 'K')
            {
                count++;
            }
            if (row + 2 < maxLenght && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
            {
                count++;
            }
            if (row + 2 < maxLenght && col + 1 < maxLenght && matrix[row + 2, col + 1] == 'K')
            {
                count++;
            }
            return count;
        }

        private static void fillMatrix(char[,] matrix)
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
    }
}
