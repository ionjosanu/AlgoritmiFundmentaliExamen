using System;
using System.Collections.Generic;
using System.IO;

namespace PutereVectori2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"C:\Users\Nicu\source\repos\AlgoritmiFundmentaliExamen\PutereVectori\TextFile1.txt");
            string[] buffer = load.ReadLine().Split(' ');
            int[] v = new int[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                v[i] = int.Parse(buffer[i]);
            }
            buffer = load.ReadLine().Split(' ');
            int[] u = new int[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                u[i] = int.Parse(buffer[i]);
            }
            int[] powV = Pow(v);
            int[] powU = Pow(u);
            Console.WriteLine(ComparePow(powV, powU));
            Console.ReadKey();

        }
        private static int ComparePow(int[] v, int[] u)
        {
            int minLength = Math.Min(v.Length, u.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (v[i] > u[i])
                    return -1;
                if (v[i] < u[i])
                    return 1;
            }
            if (v.Length > u.Length)
                return -1;
            if (v.Length < u.Length)
                return 1;

            return 0;
        }
        private static int[] Pow(int[] v)
        {
            int[] freq = new int[201]; 

            int notZeroCount = 0;   
            for (int i = 0; i < v.Length; i++)
            {
                if (freq[v[i] + 100] == 0)  
                    notZeroCount++;
                freq[v[i] + 100]++; 


            }
            int[] pow = new int[notZeroCount];
            int pos = 0;

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    pow[pos] = freq[i];
                    pos++;
                }

            }
            BubbleSort(pow);
            for (int i = 0; i < pow.Length; i++)
            {
                Console.Write(pow[i] + " ");
            }
            Console.WriteLine();
            return pow;


        }
        private static void BubbleSort(int[] v)
        {
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] < v[i + 1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        sorted = false;
                    }
                }


            } while (!sorted);
        }
    }
    
}
