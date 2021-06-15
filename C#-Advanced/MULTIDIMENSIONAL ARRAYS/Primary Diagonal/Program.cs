using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            { 
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row==col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
