using System;

namespace KwadratLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            int arg = 5;
            int wynik = DoKwadratu(arg);
            Console.WriteLine("Wynik dla argumentu " + arg + " wynosi " + wynik);
            Console.WriteLine($"dla {arg} wynik to: {wynik}");
            Console.WriteLine("Funkcja wywołana z liczbą {0} zwraca wynik {1}", arg, wynik);
        }

        static int DoKwadratu(int a)
        {
            return a * a;
        }

    }
}
