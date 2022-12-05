using ExercicioList;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário# " + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write("SALÁRIO: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();

            }
            Console.Write("Insira o ID do funcionário que terá aumento salarial: ");
            int procID = int.Parse(Console.ReadLine());

            Funcionarios func = list.Find(x => x.Id == procID);
            if (func != null)
            {
                Console.Write("Entre com a porcentagem de aumento salarial: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porc);

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