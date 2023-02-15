namespace ExemplosemInterface.Entidades
{
    internal class AlugueldeCarros
    {
        public DateTime DatadeAluguel { get; set; }
        public DateTime DatadeDevolucao { get; set; }
        public Veiculos Veiculos { get; set; }
        public Fatura Fatura { get; set; }
        
        

        public AlugueldeCarros(DateTime datadeAluguel, DateTime datadeDevolucao, Veiculos veiculos)
        {
            DatadeAluguel = datadeAluguel;
            DatadeDevolucao = datadeDevolucao;
            Veiculos = veiculos;
            Fatura = null;
        }
    }
}
