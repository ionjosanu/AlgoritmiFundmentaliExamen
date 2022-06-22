using System;

namespace AlgoritmiFundmentaliExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numere = new int[] { 23, 12, 1, 4, 10, 5, 2, 1, 54 };
            for (int i = 1; i < numere.Length; i++)
            {
                int x = numere[i];
               int  j = i - 1;
                while (j>=0 && numere[j]>x)
                {
                    numere[j+1] = numere[j];
                    j--;
                }
                numere[j + 1] = x;
            }
            foreach (var item in numere)
            {
                Console.Write(item +" ");
            }
        }
    }
}
