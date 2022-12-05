using Exercicio3NotaAluno;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            double N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            
            Console.WriteLine(Aluno.retornaNum(1.0, 2.0, 3.0));
            
            Aluno aluno1 = new Aluno(Nome, N1, N2, N3);


            Console.WriteLine("Olá " + aluno1.getNome());
            Console.WriteLine("Primeira Nota " + aluno1.Nota1);
            Console.WriteLine("NOTA FINAL = " + aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno1.Aprovado() == true)
            {
                Console.WriteLine("APROVADO");
            }

            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
            Console.WriteLine(Aluno.retornaNum(4.0, 6.0));
            Console.WriteLine(Aluno.retornaNum1(4.0, 6.0, 6.0));
            Console.WriteLine(Aluno.retornaNum(4.0, 6.0));
        }
    }
}