using System;
using System.Globalization;

namespace ExercicioTV
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorToTalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidadeADD)
        {
            Quantidade = Quantidade + quantidadeADD;
        }

        public void RemoverProdutos(int quantidadeREM)
        {
            Quantidade = Quantidade - quantidadeREM;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ "
                + ValorToTalEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
