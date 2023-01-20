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
            Console.Write("Digite o nome do departamento: ");
            string deptNome = Console.ReadLine();
            Console.WriteLine("Insira os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível (Junior, MidLevel, Senior): ");
            LevelTrabalhador level = Enum.Parse<LevelTrabalhador>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(deptNome);
            Trabalhador trabalhador = new Trabalhador(nome, level, salarioBase, dept);

            Console.Write("Quantos contratos para este trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Insira os dados do contrato nº" + i + ": ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());
                HoraContrato contrato = new HoraContrato(data, valorPorHora, horas);
                trabalhador.AddContratos(contrato);


            }

            Console.WriteLine();
            Console.Write("Digite o mês e o ano para calcular o rendimento (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int anos = int.Parse(mesEano.Substring(3));
            Console.WriteLine("Nome: " + trabalhador.Name);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Name);
            Console.WriteLine("Renda para " + mesEano + ": " + trabalhador.Renda(anos, mes).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}