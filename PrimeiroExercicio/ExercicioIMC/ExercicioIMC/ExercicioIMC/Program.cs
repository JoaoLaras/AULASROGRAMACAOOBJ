using ExercicioIMC;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instaciar um objeto

            Pessoa p = new Pessoa();
            p.peso = 85;
            p.altura = 1.75;
            p.mensagem();

        }
    }
}