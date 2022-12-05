using System;
using System.ComponentModel.Design.Serialization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime D1 = DateTime.Now;
            DateTime Dat1 = new DateTime(2021, 11, 29);
            Console.WriteLine(D1);
            Console.WriteLine("1) Data: " + D1.Date);
            Console.WriteLine("2) Dia: " + D1.Day);
            Console.WriteLine("3) Dia da Semana: " + D1.DayOfWeek);
            Console.WriteLine("4) Dia do Ano: " + D1.DayOfYear);
            Console.WriteLine("5) Horas: " + D1.Hour);
            Console.WriteLine("6) Local ou Universal: " + D1.Kind);
            Console.WriteLine("7) Milesegundos: " + D1.Millisecond);
            Console.WriteLine("8) Minutos: " + D1.Minute);
            Console.WriteLine("9) Mês: " + D1.Month);
            Console.WriteLine("10) Segundos: " + D1.Second);
            Console.WriteLine("11) Ticks: " + D1.Ticks);
            Console.WriteLine("12) Horario do Dia: " + D1.TimeOfDay);
            Console.WriteLine("13) Ano: " + D1.Year);
            Console.WriteLine("************************************************");
            Console.WriteLine();


            Console.WriteLine(D1.ToLongDateString());
            Console.WriteLine();
            Console.WriteLine(D1.ToLongTimeString());
            Console.WriteLine();
            Console.WriteLine(D1.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine(D1.ToShortTimeString());
            Console.WriteLine();
            Console.WriteLine(D1.ToString());
            Console.WriteLine();
            Console.WriteLine(D1.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();
            Console.WriteLine(D1.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine("************************************************");
            Console.WriteLine();

            Console.WriteLine(D1.AddHours(2));
            Console.WriteLine();
            Console.WriteLine(D1.AddDays(7));
            Console.WriteLine();
            Console.WriteLine(D1.AddMinutes(3));
            Console.WriteLine();
            Console.WriteLine(D1.Subtract(Dat1));
            TimeSpan t2 = D1.Subtract(Dat1);
            Console.WriteLine(t2);
          




        }
    }
}