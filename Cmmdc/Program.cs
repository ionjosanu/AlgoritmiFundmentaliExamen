using System;

namespace Cmmdc
{
    internal class Program
    {
        public static int cmmdc(int x, int y)
        {
            if (y == 0) return x;
            else return cmmdc(y, x%y);
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine(cmmdc(32, 12));
        }
    }
}
