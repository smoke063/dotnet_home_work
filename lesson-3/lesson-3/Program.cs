using System;

namespace lesson_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var matrix = new int[10, 10];

            FillMatrix(matrix);
            PrintMatrix(matrix);
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            for (var j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = j;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"{matrix[i, j]} ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }

                Console.WriteLine();
            }
        }
    }
}