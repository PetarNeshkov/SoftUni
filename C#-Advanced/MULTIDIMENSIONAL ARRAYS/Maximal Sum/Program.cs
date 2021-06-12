﻿using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];
            fillMatrix(matrix);
            int MaxSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                int currSum = 0;
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    currSum = matrix[row, col] + matrix[row, col + 1] +
                              matrix[row, col + 2] + matrix[row + 1, col] +
                              matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currSum>MaxSum)
                    {
                        bestCol = col;
                        bestRow = row;
                        MaxSum = currSum;
                    }
                }
            }
            Console.WriteLine($"Sum = {MaxSum}");
            for (int row = bestRow; row <= bestRow+2; row++)
            {
                for (int col = bestCol; col <= bestCol+2; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
        private static void fillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
