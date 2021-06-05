using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];
            string input = "";
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                double[] cols = Console.ReadLine().Split().Select(double.Parse).ToArray();
                matrix[row] = new double[cols.Length];
                for (int col = 0; col < cols.Length; col++)
                {
                    matrix[row][col] = cols[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                    {
                        for (int col = 0; col < matrix[rowCurrent].Length; col++)
                        {
                            matrix[rowCurrent][col] *=2;
                        }
                    }
                }
                else
                {
                    for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                    {
                        for (int col = 0; col < matrix[rowCurrent].Length; col++)
                        {
                            matrix[rowCurrent][col] /=2;
                        }
                    }
                }
            }
            while ((input=Console.ReadLine())!="End")
            {
                string[] information = input.Split();
                if (information[0]=="Add")
                {
                    int row = int.Parse(information[1]);
                    int col = int.Parse(information[2]);
                    int value = int.Parse(information[3]);
                    if (row>=0&&row<=rows&&col>=0&&col<=matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (information[0]=="Subtract")
                {
                    int row = int.Parse(information[1]);
                    int col = int.Parse(information[2]);
                    int value = int.Parse(information[3]);
                    if (row >= 0 && row <= rows && col >= 0 && col <= matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
