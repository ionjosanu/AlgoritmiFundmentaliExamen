using System;
using System.IO;

namespace Teste
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"C:\Users\Nicu\OneDrive\Desktop\Udemy\Teste\Teste\TextFile1.txt");
            int n = int.Parse(load.ReadLine());
            int m = int.Parse(load.ReadLine());
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] line = load.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            bool[,] visited = new bool[n, m];
            int one = 0, two = 0, three = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] != 0 && !visited[i, j])
                    {
                        int start = matrix[i, j];
                        DFS(i, j, matrix, visited, start);
                        switch (start)
                        {
                            case 1:
                                one++;
                                break;
                            case 2:
                                two++;
                                break;
                            case 3:
                                three++;
                                break;

                        }
                    }
                }
            }
            Console.WriteLine(one + " " + two + " " + three);

        }

        public static void DFS(int i, int j, int[,] matrix, bool[,] visited, int start)
        {
            if (i < 0 || j < 0 || i >= matrix.GetLength(0) || j >= matrix.GetLength(1) || visited[i, j] || matrix[i, j] != start)
            {
                return;
            }
            visited[i, j] = true;

            DFS(i - 1, j, matrix, visited, start);
            DFS(i, j + 1, matrix, visited, start);
            DFS(i + 1, j, matrix, visited, start);
            DFS(i, j - 1, matrix, visited, start);
        }
    }
}

