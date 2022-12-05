using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno1 = new Aluno();
            Console.Write("Nome do aluno: ");
            Aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            Aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + Aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (Aluno1.Aprovado() == true)
            {
                Console.WriteLine("APROVADO");
            }
            
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + Aluno1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");            }
        }
    }
}
