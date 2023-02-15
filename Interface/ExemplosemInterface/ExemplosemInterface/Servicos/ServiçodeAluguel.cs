using ExemplosemInterface.Entidades;

namespace ExemplosemInterface.Servicos
{
    internal class ServiçodeAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private ITaxadeServico taxaDeServico;

        public ServiçodeAluguel(double precoHora, double precoDia, ITaxadeServico taxadeServico)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            taxaDeServico = taxadeServico;


        }
        public void ProcessarFatura(AlugueldeCarros alugueldeCarros)
        {
            TimeSpan duracao = alugueldeCarros.DatadeDevolucao.Subtract(alugueldeCarros.DatadeAluguel);
            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = taxaDeServico.Tax(pagamentoBasico);

            alugueldeCarros.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}
