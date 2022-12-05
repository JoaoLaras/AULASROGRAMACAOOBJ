using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Cliente
    {
        public int Conta { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; set; }


        public Cliente(int conta, string nome, double saldo)
        {
            Conta = conta;
            Nome = nome;
            Saldo = saldo;
        }
        public Cliente(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
            Saldo = 0;



        }
        public override string ToString()
        {
            return "Conta " + Conta + "," + " Titular: " + Nome + " Saldo " + "R$ " + Saldo;

        }
    }

}
