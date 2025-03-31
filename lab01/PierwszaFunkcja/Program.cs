using System;

namespace PierwszaFunkcja
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = MojaLiczba();
            string kom = "Oto moja szczęśliwa liczba " + MojaLiczba();
            Console.WriteLine(kom);
        }

        static int MojaLiczba()
        {
            return 7;
        }
    }
}
