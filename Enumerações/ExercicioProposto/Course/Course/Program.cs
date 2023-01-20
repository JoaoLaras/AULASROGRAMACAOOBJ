using Course;
using Course.Entidades;
using Course.Entidades.Enums;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
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
            Console.Write("Data de Aniversário: (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Cliente cliente1 = new Cliente(nome, email, data);

            Console.WriteLine("Insira os dados do pedido:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, cliente1);
            Console.Write("Quantos itens cabem neste pedido?");
            int numPed = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numPed; i++)
            {
                Console.WriteLine("Entre #" + i + " dados do item: ");
                Console.Write("Nome do Produto: ");
                string nomeProd = Console.ReadLine();
                Console.Write("Preco do Produto: ");
                double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Produto produto = new Produto(nomeProd, precoProd);
                Console.Write("Quantidade: ");
                int quant = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quant, precoProd, produto);
                order.Items.Add(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);


        }
    }
}