using Exercicio2Funcionario;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func1 = new Funcionario();

            Console.Write("Nome: ");
            Func1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            Func1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            Func1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Funcionario: " + Func1);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double AumentarSal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Func1.AumentarSalario(AumentarSal);
            Console.WriteLine("Dados atualizados: " + Func1);
            Console.WriteLine();



        }
    }
}