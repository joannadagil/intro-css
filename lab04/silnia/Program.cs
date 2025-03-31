using System;

namespace silnia
{
    class Program
    {
        static int sil(int n)
        {
            if (n < 2) return 1;
            return sil(n-1)*n;     
        }
        static void Main(string[] args)
        {
            int n = 8;
            Console.WriteLine(n + "! = " + sil(n));
        }
    }
}
