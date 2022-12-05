using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAR UMA MATRIZ DE 2 LINHAS E 3 COLUNAS
            double[,] mat = new double[2, 3];

            //Quantos elementos a matriz tem no total
            Console.WriteLine(mat.Length);


            //Quanto é a primeira dimensao da matriz = 2 linhas;
            Console.WriteLine(mat.Rank);

            //MATRIZ NA SEGUNDA DIMENSAO TEM TAMANHO 3 = 3 COLUNAS
            Console.WriteLine(mat.GetLength(1));


            //MATRIZ NA SEGUNDA DIMENSAO TEM TAMANHO 3 = 3 COLUNAS
            Console.WriteLine(mat.GetLength(0));

        }
    }
}