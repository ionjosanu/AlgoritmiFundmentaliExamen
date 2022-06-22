using System;

namespace FrameMatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[23, 23];
            //build matrix
            for (int k = 0; k < 23 / 2; k++)
            {
                int n;
                if (k % 2 == 0)
                {
                    n = 1;
                }
                else
                {
                    n = 0;
                }

                for (int j = k; j < 23 - k; j++)
                {
                    matrix[k, j] = n;
                }
                for (int i = 1 + k; i < 23 - k; i++)
                {
                    matrix[i, 23 - 1 - k] = n;
                }
                for (int j = 23 - 2 - k; j >= k; j--)
                {
                    matrix[23 - 1 - k, j] = n;
                }
                for (int i = 23 - 2 - k; i >= k; i--)
                {
                    matrix[i, k] = n;
                }
            }




            //show matrix
            for (int i = 0; i < 23; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        }
}
