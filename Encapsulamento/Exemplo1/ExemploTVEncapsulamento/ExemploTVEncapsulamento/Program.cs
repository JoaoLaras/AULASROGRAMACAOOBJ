using ExercicioTV;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Console.WriteLine("Entre os dados do produto: ");
            //Console.Write("Nome: ");
            //string nomeProduto = Console.ReadLine();
            //Console.Write("Preço: ");
            //double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Console.Write("Quantidade no estoque: ");
            // int quantidadeProduto = int.Parse(Console.ReadLine());

            Produto produto3 = new Produto("TV", 500.00, 10);

            Console.WriteLine(produto3.Nome);
            Console.WriteLine(produto3.Preco);
            Console.WriteLine(produto3.Quantidade);
            
            

            Console.WriteLine();

            produto3.Nome = "TV 4K ";
            /*produto3.Preco = 400.00;
            produto3.Quantidade = 50;
           

            //NAO POSSO ALTERAR O PRECO E A QUANTIDADE POIS NAO FOI CRIADO UM METODO SET PARA AMBOS ***
            /*produto3.SetPreco( 200.00);
            produto3.SetQuantidade(50);*/
            Console.WriteLine(produto3.Nome);
            Console.WriteLine(produto3.Preco);
            Console.WriteLine(produto3.Quantidade);


            // Produto produto2 = new Produto();

            /*Produto produto1 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 5
            };

            */


        }
    }
}