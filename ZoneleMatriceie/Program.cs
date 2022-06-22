using System;

namespace ZoneleMatriceie
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int[,] matrix=new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i!=(n/2) &&j != (n / 2))
                    {
                        //NORD
                        if (i < j && i + j < n - 1)
                        {
                            if (j < n / 2)
                            {
                                matrix[i, j] = 1;
                            }
                            else
                            {
                                matrix[i, j] = 2;
                            }
                        }
                        //EST
                        if (i < j && i + j > n - 1)
                        {
                            if (i < n / 2)
                            {
                                matrix[i, j] = 3;
                            }
                            else
                            {
                                matrix[i, j] = 4;
                            }
                        }
                        //SUD
                        if (i > j && i + j > n - 1)
                        {
                            if (j > n / 2)
                            {
                                matrix[i, j] = 5;
                            }
                            else
                            {
                                matrix[i, j] = 6;
                            }
                        }
                        //VEST
                        if (i > j && i + j < n - 1)
                        {
                            if (i > n / 2)
                            {
                                matrix[i, j] = 7;
                            }
                            else
                            {
                                matrix[i, j] = 8;
                            }
                        }
                    }
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
