using System;
using System.Globalization;

namespace TESTEEE
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }

        public double SaldoConta { get; private set; }

        public ContaBancaria(int numeroConta, string titularConta)
        {
            this.NumeroConta = numeroConta;
            this.TitularConta = titularConta;
            SaldoConta = 0.0;
        }

        public ContaBancaria(int numeroConta, string titularConta, double saldoConta) : this(numeroConta, titularConta)
        {
            this.SaldoConta = saldoConta;
        }

        public void ValorDep(double valorDep)
        {
            SaldoConta = SaldoConta + valorDep;
        }

        public void ValorSaq(double valorSaq)
        {
            double taxa = 5.0;
            SaldoConta = SaldoConta - valorSaq - taxa;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", " + "Titular: "
                + TitularConta + ", "
                + "Saldo: R$ "
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
