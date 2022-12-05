using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");

            string nome = Console.ReadLine();
            

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto:");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade  e altura (mesma linha");

            string[] vet = Console.ReadLine().Split(' ');
            string ult = vet[0];
            int idade = int.Parse(vet[1]);
            double alutra = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ult);
            Console.WriteLine(idade);
            Console.WriteLine(alutra.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(---------------------------------);


        }
    }
}