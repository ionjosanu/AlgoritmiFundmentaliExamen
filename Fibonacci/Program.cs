﻿using System;

namespace Fibonacci
{
    internal class Program
    {
        public static int fibonacci(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return fibonacci(n-1) + fibonacci(n-2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(1));
        }
    }
}
