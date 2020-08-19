using System;

namespace Lab1PatternC
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = new char[10, 10];


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = '*';
                }
                for (int j = 0; j < i; j++)
                {
                    arr[i, j] = '-';
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

