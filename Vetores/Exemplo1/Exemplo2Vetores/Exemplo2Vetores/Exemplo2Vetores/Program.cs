using Exemplo2Vetores;
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Produtos[] vet = new Produtos[N];

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produtos { Nome = nome, Preco = preco };
                soma = soma + vet[i].Preco;
                
            }

            double media = soma / N;
            Console.WriteLine("Preco médio igual a " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}