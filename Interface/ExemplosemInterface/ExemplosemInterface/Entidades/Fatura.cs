using System.Globalization;
namespace ExemplosemInterface.Entidades
{
    internal class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }
        
        public Fatura(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }
        public double PagamentoTotal
        {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString()
        {
            return "Pagamento basico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
