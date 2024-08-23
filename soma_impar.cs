using System;
using System.Globalization;

namespace Program
{
    class Impar
    {
        static void Main(string[] args)
        {
            int a, b, inverte, soma;

            Console.WriteLine("Digite Dois Números: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            soma = 0;

            if(a > b)
            {
                inverte = a;
                a = b;
                b = inverte;
            }
            for(int i = a + 1; i < b; i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("SOMA DOS IMPARES: " + soma);

        }
    }
}
