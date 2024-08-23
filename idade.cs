using System;
using System.Globalization;

namespace Idade
{
    class Problema
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            string nome1, nome2;
            int idade1,idade2;
            double media;

            Console.WriteLine("Dados da primeira pessoa: ");

            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine(),culture);

            Console.WriteLine("Dados da segunda pessoa: ");

            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine(),culture);

            media = (idade1 + idade2) / 2.0;

            Console.WriteLine("A media das idades de " + nome1 + " e " + nome2 + " é: " + media.ToString("F1",culture) + " anos");




        }
    }
}
