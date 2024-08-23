using System;
using System.Globalization;


namespace Program
{
    class Somavetor
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            int N;
            double soma;
            soma = 0;

            Console.Write("Quantos números você vai digitar? ");
            N = int.Parse(Console.ReadLine(),culture);

            double[] vet = new double [N];

            for (int i = 0; i < N; i++) 
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Numeros digitados: ");

            for (int i = 0; i < N; i++) 
            { 
                Console.WriteLine((vet[i]).ToString("F1",culture));
            }
            for(int i = 0;i < N; i++)
            {
                soma += vet[i];
            }
            Console.WriteLine("SOMA = " + soma.ToString("F1", culture));
            Console.WriteLine("MEDIA = " + (soma / N).ToString("F1",culture));



        }
    }
}
