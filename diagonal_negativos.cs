using System;
using System.Globalization;

namespace Program
{
    class DiagonalNegativos
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.CurrentUICulture;

            int ordem;

            int C, L;

            Console.WriteLine("Qual a ordem da matriz? ");
            ordem = int.Parse(Console.ReadLine());

            C = ordem;
            L = ordem;

            int[,] mat = new int[L, C];


            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }


            }
            Console.WriteLine("NEGATIVOS: ");
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }
            Console.WriteLine("DIAGONAL: ");
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }

        }
    }
}
