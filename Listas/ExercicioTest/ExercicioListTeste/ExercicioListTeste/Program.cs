using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioListTeste;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Funcionários serão registrados? ");
            int N = int.Parse(Console.ReadLine());
            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int numId = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(numId, nome, salario));
                Console.WriteLine();

            }

            Console.Write("Entre com o Id do funcionário que terá aumento: ");
            int procId = int.Parse(Console.ReadLine());

            Funcionarios func = list.Find(x => x.Id == procId);

            if (func != null)
            {
                Console.Write("Entre com a porcentagem de aumento salarial: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentarSalario(porc);
            }
            else
            {
                Console.WriteLine("ID não existe! ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada:");

            foreach (Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}