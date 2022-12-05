using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma = vet[i] + soma;
            }

            double media = soma / N;
            Console.WriteLine("A altura media é " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}