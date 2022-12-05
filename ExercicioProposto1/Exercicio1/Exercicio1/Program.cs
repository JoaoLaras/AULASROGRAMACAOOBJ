using Exercicio1;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Globalization;
using System.Net.Http.Headers;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char DepInc = char.Parse(Console.ReadLine());
            
            if (DepInc == 's')
            {
                double saldo = 0.0;
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
            }
            else
            {
                double saldo = 0.0;
            }
            

            Cliente c1 = new Cliente(conta, titular, saldo);
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine();
        }
    }
}