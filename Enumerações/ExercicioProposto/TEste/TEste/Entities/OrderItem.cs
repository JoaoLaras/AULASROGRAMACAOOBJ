using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEste.Entities
{
    internal class OrderItem

    {
        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantidade, double preco, Product product)
        {
            Quantidade = quantidade;
            Preco = preco;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", Quantidade: " + Quantidade + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }

}
