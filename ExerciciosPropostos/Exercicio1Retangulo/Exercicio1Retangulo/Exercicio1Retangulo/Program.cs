using Exercicio1Retangulo;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo:");
            retangulo1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + retangulo1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + retangulo1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}