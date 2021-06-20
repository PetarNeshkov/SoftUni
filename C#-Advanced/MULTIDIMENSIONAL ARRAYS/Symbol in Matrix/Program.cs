using System;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            bool check = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] text = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = text[col];
                }
            }
            string element = Console.ReadLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].ToString().Contains(element))
                    {
                        Console.WriteLine($"({row}, {col})");
                        check = true;
                        return;
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine($"{element} does not occur in the matrix");
            }
        }
    }
}
