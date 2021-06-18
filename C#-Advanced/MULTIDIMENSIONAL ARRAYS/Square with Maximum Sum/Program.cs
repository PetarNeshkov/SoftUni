using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int columns = sizes[1];
            int[,] matrix = new int[rows, columns];
            int BestRow = 0;
            int BestCollumn = 0;
            int bestSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[]columnData= Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnData[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int currSUm = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1]
                        + matrix[row + 1, col + 1];
                    if (currSUm>bestSum)
                    {
                        bestSum = currSUm;
                        BestRow = row;
                        BestCollumn = col;
                    }
                }
            }
            Console.WriteLine(matrix[BestRow,BestCollumn]+" "+ (matrix[BestRow, BestCollumn+1]));
            Console.WriteLine((matrix[BestRow+1, BestCollumn]+" "+((matrix[BestRow+1, BestCollumn+1]))));
            Console.WriteLine(bestSum);
        }
    }
}
