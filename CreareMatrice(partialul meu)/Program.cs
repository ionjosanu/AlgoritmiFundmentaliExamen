using System;

namespace CreareMatrice_partialul_meu_
{
    /*
     creare matrice
    5 4 3 2 1 0
    4 3 2 1 0 1
    3 2 1 0 1 2
    2 1 0 1 2 3
    1 0 1 2 3 4
    0 1 2 3 4 5
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
           //creare matrice
            for (int i = 0; i < n; i++)
            {
                int x = n-i-1;
                int y = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i + j <= n - 1)
                    {
                        matrix[i,j] = x--;
                    }
                    else
                    {
                        matrix[i,j] = y++;
                    }
                }
            }
            // afisare matrice
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
