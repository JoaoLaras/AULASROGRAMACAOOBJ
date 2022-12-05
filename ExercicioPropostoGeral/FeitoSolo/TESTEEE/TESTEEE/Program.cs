using System;
using System.Globalization;
using TESTEEE;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char haveraDep = char.Parse(Console.ReadLine());

            if (haveraDep == 's' || haveraDep == 'S')
            {
                Console.Write("Entre um valor de depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numConta, titularConta, depInicial);
            }
            else
            {
                conta = new ContaBancaria(numConta, titularConta);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.ValorDep(valorDep);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.ValorSaq(valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("A titular alterou o nome! ");
            Console.WriteLine("Digite seu novo nome ");
            string altNome = Console.ReadLine();
            conta.TitularConta = altNome;
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            

        }
    }
}