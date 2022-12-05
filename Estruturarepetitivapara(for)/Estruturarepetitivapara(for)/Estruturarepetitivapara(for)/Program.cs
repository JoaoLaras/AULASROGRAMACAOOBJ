using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int N1 = int.Parse(Console.ReadLine());
                soma += N1;
            }
            Console.WriteLine("Soma = " + soma);
            Console.WriteLine();
        }
    }
}