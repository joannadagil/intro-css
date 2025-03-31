using System;

namespace ConsoleApp1
{
    class Program
    {

        static int Spolgloski(string napis)
        {
            int suma = 0;
            string spolgloski = "BbCcDdFfGgHhJjKkLlMmNnPpRrSsTtWwXxZz";
            for (int i = 0; i < napis.Length; i++)
            {
                char n = napis[i];
                
                for (int j = 0; j < spolgloski.Length; j++)
                {
                    if (n == spolgloski[j])
                        suma++;
                }
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Spolgloski("Hello World!"));
        }
    }
}
