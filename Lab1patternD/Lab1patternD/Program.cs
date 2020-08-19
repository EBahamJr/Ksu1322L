using System;

namespace Lab1patternD
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = new char[10, 10];


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i < 5)
                {
                    for (int j = 0; j < 4-i; j++)
                    {
                        if (j >= 0)
                        {
                            arr[i, j] = '-';
                        }
                    }
                    for (int j = 4 - i; j < 4; j++)
                    {
                        if (j >= 0)
                        {
                            arr[i, j] = '*';
                        }
                    }
                    for(int m = 0; m < 10; m++)
                    {
                        arr[i, 4] = '*';
                    }
                    for (int j = 4 + i; j > 4; j--)
                    {
                        if (j >= 0)
                        {
                            arr[i, j] = '*';
                        }
                    }
                }
                if (i >= 5)
                {
                    for (int j = 0; j < i - 4; j++)
                    {
                        if (j >= 0)
                        {
                            arr[i, j] = '-';
                        }
                    }
                    for (int j = i-5 ; j < 4; j++)
                    {
                        if (j >= 0)
                        {
                            arr[i, j] = '*';
                        }
                    }
                    for (int m = 0; m < 10; m++)
                    {
                        arr[i, 4] = '*';
                    }
                    for (int j = 5; j < 9 - (i - 5); j++)
                    {
                        if (j >= 0)
                        {
                            arr[i, j] = '*';
                        }
                    }
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
