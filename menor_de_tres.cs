using System;
using System.Globalization;

namespace Program
{
    class menor_de_tres
    {
        static void Main(string[] args)
        {

            CultureInfo culture = CultureInfo.InvariantCulture;

            double numero1, numero2, numero3;

            Console.Write("Primeiro Valor: ");
            numero1 = double.Parse(Console.ReadLine(),culture);
            Console.Write("Segundo Valor: ");
            numero2 = double.Parse(Console.ReadLine(),culture);
            Console.Write("Terceiro Valor: ");
            numero3 = double.Parse(Console.ReadLine(),culture);

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("Maior Valor: " + numero1);
            }
            else if(numero2 > numero1 && numero2 > numero3){
                Console.WriteLine("Maior Valor: " + numero2);
            }
            else
            {
                Console.WriteLine("Maior Valor: " + numero3);
            }

         
        }
    }
}
