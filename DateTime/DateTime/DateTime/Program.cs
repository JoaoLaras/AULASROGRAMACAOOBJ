using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HORARIO ATUAL DO SISTEMA
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine();


            //CONSTRUTOR ANO MES E DIA
            DateTime d2 = new DateTime(2022, 11, 29);
            Console.WriteLine(d2);

            //CONSTRUTOR ANO MES DIA, HORAS MINUTOS E SEGUNDOS.
            Console.WriteLine();
            DateTime d3 = new DateTime(2022, 11, 29, 18, 47, 01);
            Console.WriteLine(d3);

            //CONSTRUTOR ANO MES DIA, HORAS MINUTOS E SEGUNDOS E MILESIMOS DE SEGUNDOS
            Console.WriteLine();
            DateTime d4 = new DateTime(2022, 11, 29, 18, 47, 01, 500);
            Console.WriteLine(d4);
            Console.WriteLine();


            //HORARIO ATUAL DO SISTEMA
            DateTime d5 = DateTime.Now;

            //ZERAR HORARIO
            DateTime d6 = DateTime.Today;


            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine();


            DateTime d7 = DateTime.UtcNow;
            Console.WriteLine(d7);

            Console.WriteLine("------------------------------------------------------------");
            //USANDO .PARSE NO DATETIME
            DateTime d8 = DateTime.Parse("29-11-2022");
            DateTime d9 = DateTime.Parse("29-11-2022 18:57:01");
            DateTime d10 = DateTime.Parse("29/11/2022 18:57:01");
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            Console.WriteLine("------------------------------------------------------------");
            //USANDO .PARSEEXACT
            DateTime d11 = DateTime.ParseExact("2022-11-29", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
            Console.WriteLine();
            DateTime d12 = DateTime.ParseExact("29/11/2022 19:05:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);



        }
    }
}