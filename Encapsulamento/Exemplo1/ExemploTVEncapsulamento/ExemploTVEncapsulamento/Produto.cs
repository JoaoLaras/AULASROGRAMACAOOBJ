using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ExercicioTV
{
    internal class Produto
    {   // atributo privativo
        private string _nome;

        // propriedades autoimplementadas
        public double Preco { get; set; }
        public int Quantidade { get; private set; }


        // CONSTRUTOR PADRAO
        public Produto()
        {

        }

        //CONSTRUTOR
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // propriedades customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        /*public string GetNome()
        {
            return _nome;
        }
        */
        /*
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        /*public double GetPreco()
        {
            return _preco;
        }
        */

        /* public int Quantidade
         {
             get { return _quantidade; }
             set { _quantidade = value; }
         }

         /*
         public int GetQuantidade()
         {
             return _quantidade;
         }

         //INCLUINDO UMA LOGICA ASSEGURO QUE MANTENHO O ESTADO CONSISTENTE DO ATRIBUTO
         /*
         public void SetNome(string nome)
         {   if (nome != null && nome.Length > 1)
             {
                 _nome = nome;
             }

         }
         //PARA NAO ALTERAR DE JEITO NENHUM O PRECO E A QUANTIDADE
         /*public void SetPreco(double preco)
         {
             _preco = preco;
         }

         public void SetQuantidade(int quantidade)
         {
             _quantidade = quantidade;
         }
         */


        //SOBRECARGA
        /*public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;

        }*/

        //

        //OUTROS METODOS
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
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ "
                + ValorToTalEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
