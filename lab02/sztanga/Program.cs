using System;

namespace sztanga
{
    class Program
    {
        static void Main(string[] args)
        {
            int małe = 2;
            int duże = 3;
            Console.WriteLine(Masa(małe, duże));
        }

        static int Masa(int małe, int duże)
        {
            return 20 + 10 * małe + 20 * duże;
        }
    }
}
