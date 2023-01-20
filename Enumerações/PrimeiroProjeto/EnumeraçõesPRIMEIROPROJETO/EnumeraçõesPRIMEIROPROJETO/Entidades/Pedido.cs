using System;
using EnumeraçõesPRIMEIROPROJETO.Entidades.Enums;

namespace EnumeraçõesPRIMEIROPROJETO.Entidades
{
    internal class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Momento + ", " + Status;
        }


    }
}
