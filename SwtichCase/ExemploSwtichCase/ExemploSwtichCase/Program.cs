using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {  /* 
            int x = int.Parse(Console.ReadLine());
            string dia;

            if (x == 1)
            {
                dia = "Domingo";
            }

            else if (x == 2)
            {
                dia = "Segunda";
            }

            else if (x == 3)
            {
                dia = "Terça";
            }

            else if (x == 4)
            {
                dia = "Quarta";
            }

            else if (x == 5)
            {
                dia = "Quinta";
            }

            else if (x == 6)
            {
                dia = "Sexta";
            }

            else if (x == 7)
            {
                dia = "Sabádo";
            }

            else
            {
                dia = "Valor Inválido";
            }

            Console.WriteLine("Dia: " + dia);*/


            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;

                case 2:
                    dia = "Segunda";
                    break;

                case 3:
                    dia = "Terca";
                    break;

                case 4:
                    dia = "Quarta";
                    break;

                case 5:
                    dia = "Quinta";
                    break;

                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sabado";
                    break;

                default:
                    dia = "Valor Inválido";
                    break;
            }
            Console.WriteLine("Dia: " + dia);
        }
    }
}