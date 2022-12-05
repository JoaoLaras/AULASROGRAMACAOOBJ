using System;


namespace ExerciciodeFixacaoMEMBROSESTATICOS
{   
    
    internal class ConversordeMoeda
    {
        public static double iof = 6.0;
        public static double valorPagoReais(double cotDolar, double compDolar)
        {
            double valorCompra = cotDolar * compDolar;
            return (valorCompra / 100 * iof) + valorCompra;
        }
    }
}
