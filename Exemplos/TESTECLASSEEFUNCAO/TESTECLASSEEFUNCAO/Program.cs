using System;
using TESTECLASSEEFUNCAO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeros3 N;
            N = new Numeros3();

            Console.WriteLine("Digite três números");

            N.N1 = int.Parse(Console.ReadLine());
            N.N2 = int.Parse(Console.ReadLine());
            N.N3 = int.Parse(Console.ReadLine());

            int Resultado = Maior(N.N1, N.N2, N.N3);

            Console.WriteLine("Maior =" + Resultado);
         
        }

        static int Maior(int A, int B, int C)
        {
            int m; 
            if (A>B && A>C)
            {
                m = A;
            }
            else if (B > C)
            {
                m = B;
            }
            else
            {
                m = C;
            }
            return m;
        }

    }
}