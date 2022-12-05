using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine();
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Dias: " + t.Days);
            Console.WriteLine("Horas: " + t.Hours);
            Console.WriteLine("Minutos: " + t.Minutes);
            Console.WriteLine("Segundos: " + t.Seconds);
            Console.WriteLine("MilesimodeSegundos: " + t.Milliseconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("**********************************************");
            Console.WriteLine("Total Dias: " + t.TotalDays);
            Console.WriteLine("Total Horas: " + t.TotalHours);
            Console.WriteLine("Total Minutos: " + t.TotalMinutes);
            Console.WriteLine("Total Segundos: " + t.TotalMinutes);
            Console.WriteLine("Total Milesimosdesegundos: " + t.TotalMilliseconds);
            Console.WriteLine("**********************************************");
            //SOMA
            TimeSpan time = new TimeSpan(1, 30, 10);
            TimeSpan time1 = new TimeSpan(0, 10, 5);
            TimeSpan soma = time.Add(time1);
            Console.WriteLine(soma);

            //SUBTRACAO
            Console.WriteLine("**********************************************");
            TimeSpan subtracao = time.Subtract(time1);
            Console.WriteLine(subtracao);
            Console.WriteLine("**********************************************");

            //MULTIPLICAO
            TimeSpan mult = time1.Multiply(2.0);
            Console.WriteLine(mult);
            Console.WriteLine("**********************************************");

            //DIVISAO
            TimeSpan div = time1.Divide(2);
            Console.WriteLine(div);

        }
    }
}