using System;

namespace kosmos
{
    class Program
    {
        static void Main(string[] args)
        {
            double d_rury = 3;
            double r_kuli = 10;
            double a_szesciokata = 100;
            Console.WriteLine(Pow(d_rury, r_kuli, a_szesciokata));

        }

        static double Pow(double d_rury, double r_kuli, double a_sze)
        {
            double v_kuli = 4 / 3 * Math.PI * r_kuli * r_kuli * r_kuli;
            double v_rury = (a_sze - 2 * r_kuli) * Math.PI * d_rury * d_rury / 4;

            return v_kuli * 7 + v_rury * 12;
        }
    }
}
