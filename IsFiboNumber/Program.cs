using System;
using System.IO;


namespace IsFiboNumber
{
    internal class Program
    {
        static bool isPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }
        static bool isFibonacci(int n)
        {
           
            return isPerfectSquare(5 * n * n + 4) ||
                   isPerfectSquare(5 * n * n - 4);
        }
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"C:\Users\Nicu\source\repos\AlgoritmiFundmentaliExamen\IsFiboNumber\TextFile1.txt");
            int n=int.Parse(load.ReadLine());
            int[] arr=new int[n];
            string[] buffer= load.ReadLine().Split(' ');
           
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(buffer[i]);
            }
            //sortam descrescator vectorul initial 
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (arr[i]<arr[j])
                    {
                       int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
            //afisam numerele din sirul fibo
            for (int i = 0; i < n; i++)
            {
                if (isFibonacci(arr[i]))
                {
                    Console.Write(arr[i]+ " ");
                }
            
            }
            

        }
    }
}
