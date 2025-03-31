using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = 20;
            double d = 5;
            double ph = 3;
            double sz = 2;
            double alfa = 30;


            Console.WriteLine(Pow(h, d, ph, sz, alfa));
        }

        static double Pow(double h, double d, double ph, double sz, double alfa)
        {
            double alfa_radian = alfa * Math.PI / 180; 
            double r_podstawy = d / 2;
            double r_zbiornika = sz * r_podstawy;

            // h = h_zbiornika + h_podst + h_dachu
            // h_podst = h_zbiornika * ph
            // h_dachu = tan(alfa) * r_zbiornika
            // h = h_zbiornika(1 + ph) + h_dachu

            double h_dachu = Math.Tan(alfa_radian) * r_zbiornika;

            double h_zbiornika = (h - h_dachu) / (1 + ph);
            double h_podst = h_zbiornika * ph;

            double pow_dachu = Math.PI * r_zbiornika * r_zbiornika / (Math.Cos(alfa_radian));
            double pow_zbiornika = Math.PI * 2 * r_zbiornika * h_zbiornika;
            double pow_podst = Math.PI * 2 * r_podstawy * h_podst;
            double pow_spodu = Math.PI * r_podstawy * r_podstawy;

            return pow_dachu + pow_zbiornika + pow_podst + pow_spodu;
        }
    }
}
