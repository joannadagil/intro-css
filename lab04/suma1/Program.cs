using System;

namespace suma1
{
    class Program
    {
        static ulong Suma1(uint n)
        {
            if (n == 0) return 0;
            return n + Suma1(n - 1);
        }

        static ulong SumaNieparzystych1(uint n)
        {
            if (n % 2 == 0) return SumaNieparzystych1(n - 1);
            if (n == 1) return 1;
            if (n == 0) return 0;
            return n + SumaNieparzystych1(n - 2);
        }
        static ulong Suma2(uint n)
        {
            if (n == 0) return 0;
            return Suma1(n - 1);
        }

        static ulong SumaNieparzystych2(uint n)
        {
            if (n == 0) return 0;
            return SumaNieparzystych1(n - 1);
        }

        static ulong SumaKwadratow1(uint n)
        {
            if (n == 0) return 0;
            return n * n + SumaKwadratow1(n-1);
        }

        static ulong SumaKwadratow2(uint n)
        {
            if (n == 0) return 0;
            return SumaKwadratow1(n - 1);
        }

        static ulong SumaLiczb(uint n)
        {
            if (n == 0) return 0;
            if (n % 3 == 0 && n % 7 != 0)
                return n + SumaLiczb(n - 1);
            return SumaLiczb(n - 1);
        }

        static uint IleCyfr2(ulong liczba)
        {
            if (liczba == 0) return 0;
            if (liczba % 10 == 2)
                return 1 + IleCyfr2(liczba / 10);
            return IleCyfr2(liczba / 10);
        }

        static uint IleCyfr2w7(ulong liczba)
        {
            if (liczba == 0) return 0;
            if (liczba % 7 == 2)
                return 1 + IleCyfr2w7(liczba / 7);
            return IleCyfr2w7(liczba / 7);
        }

        static string Linia1(uint n)
        {
            if (n == 0) return "0";
            return Linia1(n - 1) + " " + n;
        }
        static string Linia2(uint n)
        {
            if (n == 0) return "0";
            return n + " " + Linia2(n - 1);
        }

        static string Linia3(uint n)
        {
            if (n == 0) return "";
            if (n == 2) return "2";
            if (n % 2 == 1) return Linia3(n - 1);
            return n + "," + Linia3(n - 2);
        }
        static string Linia4(uint n)
        {
            if (n == 3) return "3";
            if (n < 3) return "";
            if (n % 3 == 0 || n % 5 == 0) return Linia4(n-1) + "," + n;
            return Linia4(n - 1);
        }

        static int Suma12(uint n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n % 3 == 0 || n % 5 == 0) return (int)(n) + Suma12(n-1);
            return Suma12(n - 1);
        }

        static int Suma22(int a, int b, int c)
        {
            if (a > c) return 0;
            return a + Suma22(a + b, b, c);
        }
        static int Suma32(int a, int b, int c)
        {
            if (a > c) return 0;
            if (a % 3 == 0 && a % 7 != 0) return a + Suma32(a + b, b, c);
            return Suma32(a + b, b, c);
        }

        static int Iloczyn1(int a, int b, int c)
        {
            if (a > c) return 1;
            if (a % 3 == 0 || a % 7 == 0) return a * Iloczyn1(a + b, b, c);
            return Iloczyn1(a + b, b, c);
        }

        static int IleWiecej2Niz5(ulong liczba)
        {
            if (liczba == 0) return 0;
            if (liczba % 10 == 2)
                return 1 + IleWiecej2Niz5(liczba / 10);
            if (liczba % 10 == 5)
                return -1 + IleWiecej2Niz5(liczba / 10);
            return IleWiecej2Niz5(liczba / 10);
        }

        static void Main(string[] args)
        {
            uint n = 11;
            ulong m = 22222;
            ulong o = 22555555522;
            int a = 4, b = 2, c = 24;
            Console.WriteLine("Suma1(" + n + ") = " + Suma1(n));
            Console.WriteLine("SumaNieparzystych1(" + n + ") = " + SumaNieparzystych1(n));
            Console.WriteLine("Suma2(" + n + ") = " + Suma2(n));
            Console.WriteLine("SumaNieparzystych2(" + n + ") = " + SumaNieparzystych2(n));
            Console.WriteLine("SumaKwadratow1(" + n + ") = " + SumaKwadratow1(n));
            Console.WriteLine("SumaKwadratow2(" + n + ") = " + SumaKwadratow2(n));
            Console.WriteLine("SumaLiczb(" + n + ") = " + SumaLiczb(n));
            Console.WriteLine("IleCyfr2(" + m + ") = " + IleCyfr2(m));
            Console.WriteLine("IleCyfr2w7(" + m + ") = " + IleCyfr2w7(m));
            Console.WriteLine("Linia1(" + n + ") = " + Linia1(n));
            Console.WriteLine("Linia2(" + n + ") = " + Linia2(n));
            Console.WriteLine("Linia3(" + n + ") = " + Linia3(n));
            Console.WriteLine("Linia4(" + n + ") = " + Linia4(n));
            Console.WriteLine("Suma12(" + n + ") = " + Suma12(n));
            Console.WriteLine("Suma22(" + a + b + c + ") = " + Suma22(a, b, c));
            Console.WriteLine("Suma32(" + a + b + c + ") = " + Suma32(a, b, c));
            Console.WriteLine("Iloczyn1(" + a + b + c + ") = " + Iloczyn1(a, b, c));
            Console.WriteLine("IleWiecej2Niz5(" + o + ") = " + IleWiecej2Niz5(o));
        }
    }
}
