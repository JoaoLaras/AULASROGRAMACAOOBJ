using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo!");


            Console.WriteLine("------------------------------------");

            int N = int.Parse(Console.ReadLine());

            while (N != 2002)
            {
                Console.WriteLine("Senha invalida");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}