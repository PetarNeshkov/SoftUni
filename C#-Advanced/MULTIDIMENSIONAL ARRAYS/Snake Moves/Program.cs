using System;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int currLenght = 0;
            char[,] matrix = new char[rows, cols];
            char[] rowData = Console.ReadLine().ToCharArray();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = rowData[currLenght];
                        currLenght++;
                        if (currLenght == rowData.Length)
                        {
                            currLenght = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        matrix[row, col] = rowData[currLenght];
                        currLenght++;
                        if (currLenght == rowData.Length)
                        {
                            currLenght = 0;
                        }
                    }
                }
            }
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int rol = 0; rol < matrix.GetLength(0); rol++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[rol, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
