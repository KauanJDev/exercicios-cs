using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            double b, a;
            

            Console.Write("Qual a altura do retangulo? ");
            a = double.Parse(Console.ReadLine(),culture);
            Console.Write("Qual a base do retangulo? ");
            b = double.Parse(Console.ReadLine(),culture);

            double P = (2 * a) + (2 * b);
            double expoA = Math.Pow(a,2);
            double expoB = Math.Pow(b, 2);
            double D = Math.Sqrt(expoA + expoB);

            Console.WriteLine();

            Console.WriteLine("AREA: " + (b * a));
            Console.WriteLine("PERIMETRO: " +  P);
            Console.WriteLine("DIAGONAL: " + D);

        }
    }
}
