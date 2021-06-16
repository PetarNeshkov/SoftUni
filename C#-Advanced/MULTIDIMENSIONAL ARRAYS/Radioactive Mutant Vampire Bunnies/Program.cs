using System;
using System.Collections.Generic;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            char[,] matrix = new char[sizes[0], sizes[1]];
            int PlayerRow = -1;
            int PlayerCol = -1;
            for (int row = 0; row < rows; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                    if (rowData[col] == 'P')
                    {
                        PlayerRow = row;
                        PlayerCol = col;
                    }
                }
            }
            char[] directions = Console.ReadLine().ToCharArray();
            bool IsWon = false;
            foreach (char direction in directions)
            {
                int currentPlayerRow = PlayerRow;
                int currentPlayerCol = PlayerCol;
                switch (direction)
                {
                    case 'U':
                        currentPlayerRow--;
                        break;
                    case 'D':
                        currentPlayerRow++;
                        break;
                    case 'L':
                        currentPlayerCol--;
                        break;
                    case 'R':
                        currentPlayerCol++;
                        break;
                    default:
                        break;
                }
                IsWon = isWon(matrix, currentPlayerRow, currentPlayerCol);
                if (IsWon)
                {
                    matrix[PlayerRow, PlayerCol] = '.';
                }
                else
                {
                    if (matrix[currentPlayerRow, currentPlayerCol] == 'B')
                    {
                        matrix[PlayerRow, PlayerCol] = '.';
                        PlayerRow = currentPlayerRow;
                        PlayerCol = currentPlayerCol;
                    }
                    else
                    {
                        matrix[PlayerRow, PlayerCol] = '.';
                        matrix[currentPlayerRow, currentPlayerCol] = 'P';
                        PlayerRow = currentPlayerRow;
                        PlayerCol = currentPlayerCol;
                    }
                }
                List<int> bunnies = new List<int>();
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            bunnies.Add(row);
                            bunnies.Add(col);
                        }
                    }
                }
                for (int i = 0; i < bunnies.Count; i += 2)
                {
                    int bunnyRow = bunnies[i];
                    int bunnyCol = bunnies[i + 1];
                    SpreadBunny(matrix, bunnyRow, bunnyCol);
                }
                if (IsWon || matrix[PlayerRow, PlayerCol] == 'B')
                {
                    break;
                }
            }
            PrintMatrix(matrix,rows,cols);
            if (IsWon)
            {
                Console.WriteLine($"won: {PlayerRow} {PlayerCol}");
            }
            else
            {
                Console.WriteLine($"dead: {PlayerRow} {PlayerCol}");
            }
        }

        private static void PrintMatrix(char[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void SpreadBunny(char[,] matrix, int bunnyRow, int bunnyCol)
        {
            if (bunnyRow-1>=0)
            {
                matrix[bunnyRow - 1, bunnyCol] = 'B';
            }

            if (bunnyRow + 1 <matrix.GetLength(0))
            {
                matrix[bunnyRow + 1, bunnyCol] = 'B';
            }

            if (bunnyCol - 1 >= 0)
            {
                matrix[bunnyRow, bunnyCol-1] = 'B';
            }

            if (bunnyCol + 1 < matrix.GetLength(1))
            {
                matrix[bunnyRow , bunnyCol+1] = 'B';
            }
        }

        private static bool isWon(char[,] matrix, int currentPlayerRow, int currentPlayerCol)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            return currentPlayerRow < 0 || currentPlayerRow >= n 
                || currentPlayerCol < 0 || currentPlayerCol >= m;
        }
    }
}
