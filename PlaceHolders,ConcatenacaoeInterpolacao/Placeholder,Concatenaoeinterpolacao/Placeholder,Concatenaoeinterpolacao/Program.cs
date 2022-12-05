using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "João";
            int idade = 27;
            double saldo = 2.500;

            //PlaceHolders
            Console.WriteLine("{0} tem {1} anos e tem o saldo na conta bancária de R$ {2:F1}", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo na conta bancária de R$ {saldo:F2}");

            //Concatenação // SOMENTE NA CONCATENAÇÃO POSSO ALTERAR A VIRGULA POR PONTO (.)
            Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo na conta bancária de R$ " + saldo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

           



        }
    }
}