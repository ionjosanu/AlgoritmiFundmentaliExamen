
using System;
using System.IO;
using System.Collections.Generic;

namespace PareCresactoareIn2Vectori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"C:\Users\Nicu\source\repos\AlgoritmiFundmentaliExamen\PareCresactoareIn2Vectori\TextFile1.txt");
            //
            int n1 = int.Parse(load.ReadLine());
            string[] buffer = load.ReadLine().Split(' ');
            int[] v1 = new int[n1];
            for (int i = 0; i < n1; i++)
            { v1[i] = int.Parse(buffer[i]); }
            //
            int n2 = int.Parse(load.ReadLine());
             buffer = load.ReadLine().Split(' ');
            int[] v2 = new int[n2];
            for (int i = 0; i < n2; i++)
            { v2[i] = int.Parse(buffer[i]); }
            //
            List<int> even = new List<int>();
            int j = 0, k = 0;
            while (j < n1 && k < n2)
            {
                if (v1[j] < v2[k])
                {
                    if (v1[j] % 2 == 0)
                        even.Add(v1[j]);
                    j++;
                }
                else if (v2[k] < v1[j])
                {
                    if (v2[k] % 2 == 0)
                        even.Add(v2[k]);
                    k++;
                }
                else if (v1[j] == v2[k])
                {
                    if (v1[j] % 2 == 0)
                    {
                        even.Add(v1[j]);
                        even.Add(v2[k]);
                    }
                    j++;
                    k++;
                }

            }
            while (j < n1)
            {
                if (v1[j] % 2 == 0)
                    even.Add(v1[j]);
                j++;
            }
            while (k < n2)
            {
                if (v2[k] % 2 == 0)
                    even.Add(v2[k]);
                k++;
            }
            foreach (var item in even)
            {
                Console.Write(item + " ");
            }
        }
    }
}
