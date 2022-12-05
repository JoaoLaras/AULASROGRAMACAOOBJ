using ExercicioPropostoGeral;
using System.Globalization;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {

        static void Main(string[] args)

        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            String nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depInicial = char.Parse(Console.ReadLine());

            if (depInicial == 's' || depInicial == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorDepInc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numConta, nomeTitular, valorDepInc);

            }
            else
            {
                conta = new ContaBancaria(numConta, nomeTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados: ");
            conta.ValorparaDep(valorDep);
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados: ");
            conta.ValorparaSaque(valorSaque);
            Console.WriteLine(conta);




        }
    }
}