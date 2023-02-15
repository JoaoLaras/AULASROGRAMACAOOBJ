namespace ExemplosemInterface.Servicos
{
    internal class TaxadeServicoBrasileira : ITaxadeServico
    {       
        public double Tax(double quantia)
        {
            if (quantia <= 100.00)
            {
                return quantia * 0.20;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
