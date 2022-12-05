﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine("---------------------------------------------");
            //Construtor
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(19, 17, 01);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            //TimeSpan por ticks
            TimeSpan t4 = new TimeSpan(900000000L);
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t5);

            Console.WriteLine();

            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 232);
            Console.WriteLine(t6);
            Console.WriteLine("****************************************");
            //INSTANCIANDO METODO FROM / UM DIA E MEIO
            TimeSpan t7 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t7);
            Console.WriteLine();
            //INSTANCIANDO METODO FROM / UMA HORA E MEIA
            TimeSpan T8 = TimeSpan.FromHours(1.5);
            Console.WriteLine(T8);
            Console.WriteLine();

            //INSTANCIANDO METODO FROM / Um minuto e meio
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t9);
            Console.WriteLine();
            //INSTANCIANDO METODO FROM / Um segundo e meio
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t10);
            Console.WriteLine();

            //INSTANCIANDO METODO FROM / Um MILESEGUNDO E MEIO
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t11);
            Console.WriteLine();

            //INSTANCIANDO METODO FROM / POR TICKS
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t12);
            Console.WriteLine();





        }
    }
}