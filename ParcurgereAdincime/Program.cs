using System;
using System.IO;

namespace ParcurgereAdincime
{
    /// <summary>
    /// Programul determina prin parcurgerea in adancime, numarul maxim de cifre de acelasi fel care sunt alaturi in matrice
    /// </summary>
    internal class Program
    {
     
        public static int[,] matrix;
        static bool[,] boolMatrix;
        static int t, nr, nrmax = 0;
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"C:\Users\Nicu\source\repos\AlgoritmiFundmentaliExamen\ParcurgereAdincime\TextFile1.txt");
          
             matrix = new int[5, 8];
            boolMatrix = new bool[5, 8];
           

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] buffer = new string[8];
                buffer = load.ReadLine().Split(' ');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(buffer[j]);
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!boolMatrix[i, j])
                    {
                        nr = 0;
                        t = matrix[i, j];
                        PA(i, j);
                        if (nr > nrmax)
                            nrmax = nr;
                    }
                }
            }
            Console.Write(nrmax + " ");
            Console.ReadKey();
        }
     
        static void PA(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < matrix.GetLength(0) && j < matrix.GetLength(1) && !boolMatrix[i, j] && matrix[i, j] == t)
            {
                nr++;
                boolMatrix[i, j] = true;
                PA(i - 1, j);
                PA(i, j + 1);
                PA(i + 1, j);
                PA(i, j + 1);
            }
        }
    }
}
