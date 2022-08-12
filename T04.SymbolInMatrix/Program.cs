using System;
using System.Linq;

namespace T04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char[,] matrix = new char[num, num];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                char[] charInput = input.Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = charInput[col];
                }
            }
            char ch = char.Parse(Console.ReadLine());
            bool isThere = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == ch)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isThere = true;
                    }
                }
            }
            if (!isThere)
            {
                Console.WriteLine($"{ch} does not occur in the matrix ");
            }
        }
    }
}
