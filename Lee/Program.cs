using System;
using System.IO;
using System.Collections.Generic;

namespace Lee
{
    internal class Program
    {
        //gasirea celui mai scurt drum de la o pozitie la alta 
        static void Main(string[] args)
        {
          TextReader load= new StreamReader(@"C:\Users\Nicu\source\repos\AlgoritmiFundmentaliExamen\Lee\TextFile1.txt");
          int n=int.Parse(load.ReadLine());
          int[,] matrix= new int[n,n];
          int[,] D= new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] buffer = new string[n]; 
                buffer=load.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = int.Parse(buffer[j]);
                    D[i,j] = 888;
                }
               
            }
            D[0, 0] = 0;//pornim din prima pozitie sa cautam cel mai scurt drum
            Lee(matrix, 0, 0, D );
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(D[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }
        //dx si dy sunt create pentru parcurgerea vecinilor
        public static int[] dx = { 1, 0, -1, 0 };
        public static int[] dy = { 0, 1, 0, -1 };
        public static void Lee(int[,] matrix, int x, int y, int[,] D)
        {
           
            for (int i = 0; i < 4; i++)
            {
                int newx = x + dx[i];
                int newy = y + dy[i];

                if (valid(4, newx, newy))
                {
                    if ( matrix[newx, newy]==0 &&  D[newx,newy] > D[x,y] + 1)
                    {
                        D[newx,newy] = D[x,y] + 1;
                        Lee(matrix,  newx, newy, D);
                    }
                }
            }

        }
        // valid creat pentru a determina dac vecinii sunt in limita matricii
       public static bool valid(int n, int x, int y)
        {
            return x >= 0 && y >= 0 &&
            x < n && y < n;
      }
    }
}
