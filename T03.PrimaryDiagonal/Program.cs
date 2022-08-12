using System;
using System.Linq;

namespace T03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[,] matrix = new int[num, num];
            int impNum = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[row, col] = rowsInput[col];
                    if (col == impNum)
                    {
                        sum += matrix[row, col];
                    }
                }
                impNum++;
            }
            Console.WriteLine(sum);
        }
    }
}
