using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            fillMatrix(matrix);
            int prSum = 0;
            int secSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row==col)
                    {
                        prSum += matrix[row, col];
                    }
                    if (row+col==matrix.GetLength(0)-1)
                    {
                        secSum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(prSum-secSum));
        }

        private static void fillMatrix(int[,]matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
