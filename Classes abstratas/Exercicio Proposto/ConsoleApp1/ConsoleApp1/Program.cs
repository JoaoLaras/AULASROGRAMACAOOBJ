using ConsoleApp1.Entities;

using System.Globalization;
using System.Xml.Schema;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPlayer> list = new List<TaxPlayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualincome, healthexpenditures));

                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numbemployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualincome, numbemployees));

                }


            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double sum = 0.0;
            foreach (TaxPlayer tax in list)
            {
                Console.WriteLine(tax.Name + ": R$ " + tax.tax().ToString("F2", CultureInfo.InvariantCulture));
                sum = sum + tax.tax();

            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: R$ " + sum.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}