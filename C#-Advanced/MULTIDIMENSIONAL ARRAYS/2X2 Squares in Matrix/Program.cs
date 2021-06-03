using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            char[,] matrix = new char[rows, cols];
            fillMatrix(matrix,sizes[0],sizes[1]);
            int counter = 0;
            for (int row = 0; row <sizes[0]-1 ; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    char currEl = matrix[row, col];
                    if (currEl==matrix[row,col+1]&&currEl==matrix[row+1,col]
                        &&currEl==matrix[row+1,col+1])
                    {
                        counter++;
                    }
                }
            }
            if (counter>0)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        private static void fillMatrix(char[,] matrix,int rows,int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] rowData = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
