using System;

namespace ConsoleApp1
{
    class Program
    {
        static int ZwrocPierwszy(int[] tab)
        {
            return tab[0];
        }

        static int ZwrocOstatni(int[] tab)
        {
            return tab[tab.Length - 1];
        }

        static int ZwrocOstatniIndeks(int[] tab)
        {
            return tab.Length - 1;
        }

        static long Suma(int[] tab)
        {
            if (tab == null)
                throw new ArgumentNullException();
            if (tab.Length == 0)
                return 0;
            return (long)tab[0] + (long)tab[tab.Length - 1];
        }

        static long SumaKwadratow(int[] tab1, int[] tab2)
        {
            long suma = 0;
            if (tab1 == null) { }
            else if (tab1.Length == 0) { }
            else
            {
                suma += tab1[0] * tab1[0];
            }

            if (tab2 == null) { }
            else if (tab2.Length == 0) { }
            else
            {
                suma += tab2[tab2.Length-1]* tab2[tab2.Length - 1];
            }

            return suma;
        }

        static double Srednia1(int[] tab)
        {
            return Suma(tab) / 2;
        }

        static double Srednia2(int[] tab, int a, int b)
        {
            return (tab[a] + tab[b]) / 2;
        }

        static bool CzyJest(int[] T1, int a, int n = 0)
        {
            if (T1 == null) return false;
            if (T1.Length == n) return false;
            if (T1[n] == a) return true;
            return CzyJest(T1, a, n + 1);
        }

        static long SumaNieparzystych(int[] T1, int n = 0)
        {
            if (n == T1.Length) return 0;
            if (T1[n] % 2 == 0) return SumaNieparzystych(T1, n + 1);
            return T1[n] + SumaNieparzystych(T1, n + 1) ;
        }

        static int SumaNaParzystych(int[] T1, int n = 0)
        {
            if (n >= T1.Length) return 0;
            return T1[n] + SumaNaParzystych(T1, n + 2);
        }

        static int IleSpelnia(int[] T1, int n = 0)
        {
            if (n == T1.Length) return 0;
            if (T1[n] % 3 != 0 && T1[n] % 2 != 0) return 1 + IleSpelnia(T1, n + 1);
            return IleSpelnia(T1, n + 1);
        }

        static int ZnajdzMax(int[] T, int i = 0)
        {
            if (i == T.Length) return int.MinValue;

            int prob = ZnajdzMax(T, i + 1);
            if (prob > T[i]) return prob;
            return T[i];
        }

        static long Suma2(int[] T1, int n)
        {
            n++;
            n = n % 2;
            if (n >= T1.Length) return 0;
            if (T1[n] % 2 == 0)
            {
                int sec = T1[n];
                T1[n] = 99;
                return sec + Suma2(T1, n + 2);
            }
            else return Suma2(T1, n + 2);
        }

        static int SumaWZakresie(int[] T, int a, int b, int i = 0)
        {
            if (i == T.Length) return 0;
            if (T[i] > a && T[i] < b) return T[i] + SumaWZakresie(T, a, b, i + 1);
            return SumaWZakresie(T, a, b, i + 1);
        }

        static bool CzyJest2(int[] T1, int a, int n = 0)
        {
            if (n == T1.Length -1) return false;
            if (T1[n] == a && T1[n + 1] == a) return true;
            return CzyJest2(T1, a, n + 1);
        }

        static bool CzyWystepuje(char znak, string line, int i = 0)
        {
            return line.Contains(znak);
        }
        static void Main(string[] args)
        {
            int[] tab = { 0, 1 };
            int[] tab2 = { 0, 1 , 2};

            
            Console.WriteLine("Podaj znak: ");
            char znak = (char)Console.ReadLine()[0];
            Console.WriteLine("Podaj napis: ");
            string line = Console.ReadLine();

            Console.WriteLine(CzyWystepuje(znak, line));
        }
    }
}
