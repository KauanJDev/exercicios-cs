using System;
using System.Globalization;

namespace Program
{
    class crescente
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            double numero1,numero2;

            Console.WriteLine("Digite dois números: ");
            numero1 = double.Parse(Console.ReadLine(), culture);
            numero2 = double.Parse(Console.ReadLine(), culture);

            while (numero1 != numero2)
            {
                if(numero1 > numero2)
                {
                    Console.WriteLine("CRESCENTE!");
                    Console.WriteLine("Digite outros dois números: ");
                    numero1 = double.Parse(Console.ReadLine(), culture);
                    numero2 = double.Parse(Console.ReadLine(), culture);

                }
                else
                {
                    Console.WriteLine("DECRESCENTE!");
                    Console.WriteLine("Digite outros dois números: ");
                    numero1 = double.Parse(Console.ReadLine(), culture);
                    numero2 = double.Parse(Console.ReadLine(), culture);
                }
            }
        }
    }
}

