using System;

namespace Factorial
{
    internal class Program
    {
        public static int factorial(int n)
        {
            if (n==0)
            {
                return 1;
            }
            else
            {
                return factorial(n - 1) * n;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }
    }
}
