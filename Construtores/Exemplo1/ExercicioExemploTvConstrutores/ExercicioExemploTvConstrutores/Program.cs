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

            Produto produto2 = new Produto();

            Produto produto1 = new Produto { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 5 };


            Console.WriteLine();
            Console.WriteLine("Dados do produto " + produto1.ToString());

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto atualizado " + produto1);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto atualizado " + produto1);

            Console.WriteLine();


        }
    }
}