using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            /*if (preco < 20)
            {
                desconto = preco * 0.1;
            }

            else
            {
                desconto = preco * 0.05;
            } */

            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}