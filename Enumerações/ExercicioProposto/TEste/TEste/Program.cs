using System;
using System.Globalization;
using TEste;
using TEste.entities;
using TEste.Entities;
using TEste.Entities.Enums;
using System.Collections.Generic;


namespace TEste.Entities// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre dados do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Aniversario: ");
            DateTime Data = DateTime.Parse(Console.ReadLine());
            Client client1 = new Client(nome, email, Data);
            Console.WriteLine("Entre Data de Ordem");
            Console.Write("Status");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("Quantos itens cabem neste pedido?");
            int numPed = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numPed; i++)
            {
                Console.WriteLine("Entre #" + i + " dados do item: ");
                Console.Write("Nome do Produto: ");
                string nomeProd = Console.ReadLine();
                Console.Write("Preco do Produto: ");
                double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product Prod1 = new Product(nomeProd, precoProd);
                Console.Write("Quantidade: ");
                int quant = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(quant, precoProd, Prod1);
                item.Items




            }
        }
    }