using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[rows, cols];
            fillMatrix(matrix);
            string input = " ";
            while ((input = Console.ReadLine()) != "END")
            {
                string[] information = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (check(information, rows, cols))
                {
                    int row1 = int.Parse(information[1]);
                    int col1 = int.Parse(information[2]);
                    int row2 = int.Parse(information[3]);
                    int col2 = int.Parse(information[4]);

                    int firstEl = matrix[row1, col1];
                    int secEl = matrix[row2, col2];

                    matrix[row1, col1] = secEl;
                    matrix[row2, col2] = firstEl;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int rol = 0; rol < matrix.GetLength(0); rol++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[rol, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static void fillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
        private static bool check(string[] information, int rows, int cols)
        {
            if (information.Length == 5 && information[0] == "swap"
                && int.Parse(information[1]) <= rows
                && int.Parse(information[2]) <= cols
                && int.Parse(information[3]) <= rows
                && int.Parse(information[4]) <= cols)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
