using ExemplosemInterface.Entidades;
using ExemplosemInterface.Servicos;
using System;
using System.Globalization;
//SOLUCAO COM INTERFACE//ATT
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados de aluguel");
            Console.Write("Modelo de Carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Data da retirada (dd/MM/yyyy hh:mm): ");
            DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data da devolução (dd/MM/yyyy hh:mm): ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entre preco por hora: ");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre preco por dia: ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AlugueldeCarros aluguel1 = new AlugueldeCarros(retirada, devolucao, new Veiculos(modelo));
            ServiçodeAluguel serviçodeAluguel = new ServiçodeAluguel(precoHora, precoDia, new TaxadeServicoBrasileira());
            serviçodeAluguel.ProcessarFatura(aluguel1);
            Console.WriteLine("PAGAMENTO:");
            Console.WriteLine(aluguel1.Fatura);
            



        }
    }
}