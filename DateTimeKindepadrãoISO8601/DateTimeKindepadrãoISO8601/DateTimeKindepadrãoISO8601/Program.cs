using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOCAL = FUSO HORARIO DA MAQUINA EXEMPLO GMT -3 / TRES HORAS ATRASADO DO GMT
            //UTC EXEMPLO GMT - HORARIO DE LONDRES

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine(d1);
            Console.WriteLine("**************************************");
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 Utc: " + d1.ToUniversalTime());
            Console.WriteLine("**************************************");

            Console.WriteLine(d2);
            Console.WriteLine("**************************************");
            Console.WriteLine("d1: " + d2);
            Console.WriteLine("d1 Kind: " + d2.Kind);
            Console.WriteLine("d1 Local: " + d2.ToLocalTime());
            Console.WriteLine("d1 Utc: " + d2.ToUniversalTime());
            Console.WriteLine("**************************************");
            Console.WriteLine(d3);
            Console.WriteLine("**************************************");
            Console.WriteLine("d1: " + d3);
            Console.WriteLine("d1 Kind: " + d3.Kind);
            Console.WriteLine("d1 Local: " + d3.ToLocalTime());
            Console.WriteLine("d1 Utc: " + d3.ToUniversalTime());
            Console.WriteLine("**************************************");

            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");

            Console.WriteLine("ISO8601");
            Console.WriteLine();
          
            DateTime Date1 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(Date1);
            //ISO8601
            DateTime Date2 = DateTime.Parse("2000-08-15T13:05:58Z");
    

            Console.WriteLine(Date1);
            Console.WriteLine("**************************************");
            Console.WriteLine("d1: " + Date1);
            Console.WriteLine("d1 Kind: " + Date1.Kind);
            Console.WriteLine("d1 Local: " + Date1.ToLocalTime());
            Console.WriteLine("d1 Utc: " + Date1.ToUniversalTime());
            Console.WriteLine("**************************************");
            Console.WriteLine(Date2);
            Console.WriteLine("**************************************");
            Console.WriteLine("d1: " + Date2);
            Console.WriteLine("d1 Kind: " + Date2.Kind);
            Console.WriteLine("d1 Local: " + Date2.ToLocalTime());
            Console.WriteLine("d1 Utc: " + Date2.ToUniversalTime());
            Console.WriteLine("**************************************");
            Console.WriteLine(Date2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(Date2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));


        }
    }
}