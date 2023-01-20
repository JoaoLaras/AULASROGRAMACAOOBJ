using System;
using EnumeraçõesPRIMEIROPROJETO.Entidades;
using EnumeraçõesPRIMEIROPROJETO.Entidades.Enums;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum DiasdaSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };
        static void Main(string[] args)
        {

           
            DiasdaSemana ds = (DiasdaSemana)2;
            Console.WriteLine(ds);

            DiasdaSemana ds1 = DiasdaSemana.Domingo;
            Console.WriteLine(ds1);

            int ds3 = (int)DiasdaSemana.Sexta;
            Console.WriteLine(ds3);

            Pedido pedido = new Pedido()
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = OrderStatus.PagamentoPendente,

            };



            Console.WriteLine(pedido);

            // converter enumerado para string 

            string txt = OrderStatus.PagamentoPendente.ToString();
            Console.WriteLine(txt);

            // converter string para enumerado

            OrderStatus os = Enum.Parse<OrderStatus>("Entregue");

            Console.WriteLine(os);


        }
    }
}