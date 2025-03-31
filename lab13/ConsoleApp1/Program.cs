using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        ushort Mod(short liczba)
        {
            return liczba > 0 ? (ushort)liczba : (ushort)(-liczba);
        }
        static ushort NajmniejszyDzielnik(short liczba, short dzielnik = 2)
        {
            if (liczba <= (short)(1)) return (ushort)1;
            if (liczba % dzielnik == 0) return (ushort)dzielnik;
            return NajmniejszyDzielnik(liczba, (short)(dzielnik + 1));
            
        }

        static ushort IleSymboliBezwg(long liczba)
        {
            if (liczba / 10 > 0) return (ushort)(1 + IleSymboliBezwg(liczba / 10));
            return (ushort)1;
        }
        static ushort ILeSymboli(long liczba)
        {
            if (liczba < 0) return (ushort)(1 + IleSymboliBezwg(-liczba));
            return IleSymboliBezwg(liczba);
        }

        static ushort IleKiW(byte[,] tablica)
        {
            int res = 0;
            int len0 = tablica.GetLength(0);
            int len1 = tablica.GetLength(1);
            for (int i = 0; i < len0; i++)
            {
                int temp = 0;
                for (int j = 0; j < len1; j++)
                {
                    if (tablica[i, j] % 2 == 1) temp++;
                }
                if (temp > len0 / 2) res++;
            }

            for (int i = 0; i < len1; i++)
            {
                int temp = 0;
                for (int j = 0; j < len0; j++)
                {
                    if (tablica[i, j] % 2 == 1) temp++;
                }
                if (temp > len1 / 2) res++;
            }
            return (ushort)res;
        }

        static ulong Suma(ulong liczba, ulong podst)
        {
            ulong res = 0;
            while (liczba/podst > 0)
            {
                res += (liczba % podst);
                liczba /= podst; 
            }
            res += (liczba % podst);
            return res;
        }

        static ushort MaksSuma(ulong liczba)
        {
            ulong res = Suma(liczba, 2);
            for (ulong i = 3; i <= 10; i++)
            {
                ulong temp = Suma(liczba, i);
                res = temp < res ? temp : res;
            }
            return (ushort)res;
        }

        /*static bool CzyJest(char znak, string napis) { 
           int [] alfab new int[char.MaxValue];
        }*/

        static string Roznorodna(string nazwa)
        {
            StreamReader sr = new StreamReader ("file.txt");
            string line = sr.ReadLine();
            ulong res_sym = 0;
            string res_line = line;

            while (line != null)
            {
                ulong sym = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    // sym = ??
                    int j = 0;
                    while (j < i && line[j] != line[i])
                        j++;
                    if (j != i) // jest takie samo przed
                        sym++;
                }
                if (sym > res_sym)
                {
                    res_sym = sym;
                    res_line = line;
                }
                line = sr.ReadLine();
            }
            
            sr.Close();
            return res_line;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("NajmniejszyDzielnik(21) = " + NajmniejszyDzielnik(21));

            Console.WriteLine("ILeSymboli(-21) = " + ILeSymboli(-21));

            byte[,] tab = { { 1, 0, 1 }, { 1, 0, 0 }, { 0, 0, 0 } };
            Console.WriteLine("ILeKiW(tab1) = " + IleKiW(tab));
            byte[,] tab2 = { { 1, 0, 1, 0 }, { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            Console.WriteLine("ILeKiW(tab2) = " + IleKiW(tab2));

            Console.WriteLine("MaksSuma(99) = " + MaksSuma(99));
        }
    }
}
