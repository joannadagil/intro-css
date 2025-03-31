using System;

namespace fibbonaci
{
    class Program
    {
        static int fib(int n, int a, int b)
        {
            if (n < 2) return a;
            return fib(n - 1, a + b, a);
            //           1    2       
        }
        static void Main(string[] args)
        {
            int n = 8;
            Console.WriteLine(n + " liczba ciagu fib: " + fib(n, 1, 0));
        }
    }
}
