using ExerciciodeFixacaoMEMBROSESTATICOS;
using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotacão do dólar? ");
            double cdolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolar você vai comprar? ");
            double qtdolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + ConversordeMoeda.valorPagoReais(cdolar, qtdolar).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}