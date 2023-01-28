using ExercPropostoExcTratadas.Entities;
using ExercPropostoExcTratadas.Entities.Exceptions;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, initBalance, withdrawlimit);
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amountwith = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amountwith);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (DomainExceptions a)
            {
                Console.WriteLine("Saque com error " + a.Message);
            }



        }
    }
}