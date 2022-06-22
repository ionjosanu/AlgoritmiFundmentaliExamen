using System;
using System.Collections.Generic;
using System.IO;

namespace PutereVectori
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
            int[] putereV = PutereVector(v);
            int[] putereU = PutereVector(u);
            foreach (var item in putereV)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in putereU)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(ComparareVectori(putereV, putereU));
        }
        public static int[] PutereVector(int[] vector)
        {
            List<int> puteri = new List<int>();

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] != 888)
                {
                    puteri.Add(CalculPutere(vector[i], vector));
                }
            }

            int[] result = new int[puteri.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = puteri[i];
            }
            Array.Sort(result);
            Array.Reverse(result);
            return result;

        }
        public static int CalculPutere(int numar, int[] vector)
        {
            int count = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (numar == vector[i])
                {
                    count++;
                    vector[i] = 888;// 888=infinit
                }
            }
            return count;
        }
        public static int ComparareVectori(int[] v, int[] u)
        {
            if (v.Length >= u.Length)
            {
                for (int i = 0; i < u.Length; i++)
                {
                    if (v[i] > u[i])
                    {
                        return 1;
                    }
                    else if (v[i]<u[i])
                    {
                        return -1;
                    }
                }
                return 0;
            }
            else
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (v[i] > u[i])
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                return 0;
            }


        }
}   }
