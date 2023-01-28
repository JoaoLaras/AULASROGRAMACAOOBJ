using ExercPropostoExcTratadas.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel;
using System.Drawing;

namespace ExercPropostoExcTratadas.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {

            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("Error, valor de saque maior que o limite de saque disponivel");
            }
            if (amount > Balance)
            {
                throw new DomainExceptions("Error, valor de saque maior que o saldo disponivel da conta");

            }

            Balance = Balance - amount;
            
        }
    }
}
