using System;

namespace Liczba
{
    class Program
    {
        static void Zapisz(int liczba, string path)
        {
            System.IO.StreamWriter plik_zapisu = new System.IO.StreamWriter(path,false);
            plik_zapisu.WriteLine(liczba);
            plik_zapisu.Close();
        }

        static int OdczytajLiczbę(string path)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(path);
            int number = int.Parse(reader.ReadLine());
            reader.Close();
            return number;
        }
        static void Main(string[] args)
        {
            string path = "liczba.txt";
            try
            {
                Zapisz(109404, path);
            } 
            catch (ObjectDisposedException e)
            {
                Console.WriteLine("Zapis się nie powiódł");
            }
            Console.WriteLine(OdczytajLiczbę(path));
            Zapisz(109404, path);
            Console.WriteLine(OdczytajLiczbę(path));

        }
    }
}
