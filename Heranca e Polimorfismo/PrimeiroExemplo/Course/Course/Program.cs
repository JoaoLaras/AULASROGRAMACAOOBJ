using Course.Entities;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brow", 100.00, 500.00);
            Console.WriteLine(account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(account.Number);
            Console.WriteLine(account.Holder);

            Console.WriteLine("************************************************************");
            // erro pois atributo balance esta protegido = protected - account.Balance = 200.00;

            Account account1 = new Account(1001, "Alex", 0.0);
            Console.WriteLine(account1.Balance);
            Console.WriteLine(account1.Number);
            Console.WriteLine(account1.Holder);


            Console.WriteLine("**********************************************************");
            BusinessAccount baccount = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING 
            Account account2 = baccount;
            Console.WriteLine(account2.Balance);
            Console.WriteLine(account2.Number);
            Console.WriteLine(account2.Holder);
            Console.WriteLine("**********************************************************");
            Account account3 = new BusinessAccount(1002, "Maria", 0.0, 500.00);
            Console.WriteLine(account3.Balance);
            Console.WriteLine(account3.Number);
            Console.WriteLine(account3.Holder);
            Account account4 = new SavingsAccount(10, "Joao", 0.0, 0.01);
            Console.WriteLine(account3.Balance);
            Console.WriteLine(account3.Number);
            Console.WriteLine(account3.Holder);

            //DOWNCASTING - ( OPERACAO INSEGURA)
            BusinessAccount account5 = (BusinessAccount)account3;
            account5.Loan(100.00);
            SavingsAccount account6 = (SavingsAccount)account4;
            account6.Deposit(100.00);
            /*erro nao e possivel converter savingsAccount em BusinessAccount
            BusinessAccount accont7 = (BusinessAccount)account4;*/

            if (account4 is BusinessAccount)
            {
                BusinessAccount account7 = (BusinessAccount)account4;
                account7.Loan(200.00);
                Console.WriteLine("Loan!");
            }
            if (account4 is SavingsAccount)
            {
                //SavingsAccount account7 = (SavingsAccount)account4;
                //SINTAXE ALTERNATIVA PARA FAZER CASTING
                SavingsAccount account7 = account4 as SavingsAccount;
                account7.UpdateBalance();
                Console.WriteLine("Update!");
            }

            Console.WriteLine("*************************************************");
            Console.WriteLine();

            Account cc1 = new Account(1001, "Alex", 500.00);
            Account cc2 = new SavingsAccount(1002, "Ana", 500.00, 0.01);
            cc1.Withdraw(10.0);
            cc2.Withdraw(10.0);
            Console.WriteLine(cc1.Balance);
            Console.WriteLine(cc2.Balance);







        }
    }
}