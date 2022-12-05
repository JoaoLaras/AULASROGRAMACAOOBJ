
using ConsoleApp1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        

        static void Main()
        {
            TipoPagamentoBean bean1;
            bean1 = new TipoPagamentoBean();
            bean1.Nome = "PIX";
           
            Console.WriteLine(bean1.Nome);

            double num = 10;
            double num2 = 10;
            // dobrar(ref num); 

            
            //double ret = dobrar(num, ref num2);
            num = dobrar(num, ref num2);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            //Console.WriteLine(ret);


        }
        static double dobrar(double valor, ref double valor2)
        {
            valor2 *= 2;
            return valor *= 3;
           


            
        }

    }
}
