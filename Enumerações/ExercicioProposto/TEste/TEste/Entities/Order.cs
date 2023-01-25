using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TEste.entities;
using TEste.Entities.Enums;


namespace TEste.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public Client Cliente { get; set; }

        public List<OrderItem> Items = new List<OrderItem>();

        public Order()
        {


        }
        public Order(DateTime date, OrderStatus status, Client cliente)
        {
            Date = date;
            Status = status;
            Cliente = cliente;

        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);


        }

        public void RemItem(OrderItem item)
        {
            Items.Remove(item);


        }

        public double Total()
        {
            double soma = 0.0;
            foreach (OrderItem item in Items)
            {
                soma = soma + item.SubTotal();
            }

            return soma;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento da Ordem: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status da Ordem: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens da Ordem:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());

            }
            sb.AppendLine("Total do preco: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
