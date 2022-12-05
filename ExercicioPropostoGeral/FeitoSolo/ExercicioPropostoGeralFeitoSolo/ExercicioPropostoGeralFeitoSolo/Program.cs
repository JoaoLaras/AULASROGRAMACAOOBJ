using ExercicioPropostoGeralFeitoSolo;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1;

            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depInic = char.Parse(Console.ReadLine());


            if (depInic == 's' || depInic == 'S')
            {
                Console.Write("Entre com um valor de depósito inicial: ");
                double valorDepInc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta1 = new ContaBancaria(numConta, titular, valorDepInc);

            }
            else
            {
                conta1 = new ContaBancaria(numConta, titular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta1);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta: ");
            conta1.valorDep(valorDep);
            Console.WriteLine(conta1);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.valorSaque(valorSaque);
            Console.WriteLine(conta1);



        }
    }
}