using System;
using System.Globalization;

namespace ExercicioPropostoGeralFeitoSolo
{   
    internal class ContaBancaria
    {   
        public static double taxa = 5.0;
        public int NumConta { get; private set; }

        public string Titular { get; set; }

        public double Saldo { get; set; }

        public ContaBancaria(int numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numConta, string titular, double saldo) : this(numConta, titular)
        {
            
            Saldo = saldo;
        }

        public void valorDep(double valorDep)
        {
            Saldo = Saldo + valorDep;
        }

        public void  valorSaque(double valorSaq)
        {
            Saldo = Saldo - valorSaq - taxa;
        }

        public override string ToString()
        {
            return "Conta "
                + NumConta + ", "
                + "Titular "
                + Titular
                + ", " + "Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
