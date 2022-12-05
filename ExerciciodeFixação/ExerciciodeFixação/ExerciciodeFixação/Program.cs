using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            //CONCATENADO
            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arrendodando (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("____________________________________________________________________");


            //PLACEHOLDERS
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $$ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $$ {1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arrendodando (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: {0:F3}", medida);

            Console.WriteLine("____________________________________________________________________");

            //INTERPOLADO
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $$ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $$ {produto2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arrendodando (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida:F3}");

        }
    }
}

