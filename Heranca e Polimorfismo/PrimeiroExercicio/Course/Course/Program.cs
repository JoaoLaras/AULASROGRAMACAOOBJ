using Course.Entities;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee " + i + " data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Addition charge: ");
                    double additionCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Payments:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- R$ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}