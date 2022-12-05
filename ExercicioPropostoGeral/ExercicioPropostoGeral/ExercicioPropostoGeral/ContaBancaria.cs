using System;
using System.Globalization;


namespace ExercicioPropostoGeral
{  
     class ContaBancaria
    {
        public static double taxa = 5.0;
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }

        public double Saldo { get; set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        public double ValorparaDep(double valordep)
        {
            return Saldo = Saldo + valordep;
        }

        public double ValorparaSaque(double valorsaque)
        {
            return Saldo = Saldo - valorsaque - taxa;
        }


        public override string ToString()
        {
            return "Conta " + NumeroConta +
                ", " + "Titular: "
                + Titular + ", "
                + "Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
