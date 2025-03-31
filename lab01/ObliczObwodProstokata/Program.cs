using System;

namespace ObliczObwodProstokata
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            Console.WriteLine($"Obwód dla prostokąta {a}x{b} wynosi {Obw(a,b)}");
        }
        static int Obw(int a, int b)
        {
            return a * b;
        }
    }
}
