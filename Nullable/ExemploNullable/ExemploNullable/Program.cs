using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            /*METODO -  PEGA O VALOR DO X OU SE NAO TIVER
            PEGA O VALOR PADRAO DA VARIAVEL X - NO CASO 0*/
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            /*VAI DIZER SE TEM VALOR NA VARIAVEL X e Y; = FALSE OU TRUE
             */
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue) 
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
        }
    }
}
//Operador de coalescência nula
//double? x = null;
//CASO O X TENHA VALOR JOGA NA VARIAVEL Y, CASO FOR NULO JOGA O VALOR DA DIREITA.
//double y = x ?? 0.0;

// double? x = null;
// double? y = 10;

// double a =  x ?? 5;
//double b = y ?? 5;

//Console.WriteLine(a);
//Console.WriteLine(b);