using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i= 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i,j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal Principal");

            for(int i = 0; i < N; i++) {

                Console.Write(mat[i,i]+" ");
                }

            Console.WriteLine();

            int count = 0;
            for (int i =0; i < N; i++)

            {  
                for (int j=0; j < N; j++)
                {
                    if (mat[i,j] < 0 )
                    {
                        count = count + 1;
                    }
                }
            }

            Console.WriteLine("Quantidade de números negativos: " + count);
        }
    }
}