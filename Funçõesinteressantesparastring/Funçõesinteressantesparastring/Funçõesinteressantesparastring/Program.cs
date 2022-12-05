using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            //COLOCAR TUDO EM MAISCULO
            string s1 = original.ToUpper();

            //colocar tudo em minusculo
            string s2 = original.ToLower();

            //apagar espaco em branco
            string s3 = original.Trim();

            //primeira ocorrencia do 'bc'
            int n1 = original.IndexOf("bc");

            //ultima ocorrencia do 'bc'
            int n2 = original.LastIndexOf("bc");

            //corta o string por sobrecarga na posicao 3
            string s4 = original.Substring(3);

            //corta o string por sobrecarga na posicao 3 com 5 caracteres
            string s5 = original.Substring(3, 5);

            // sobrecarga de substituir um caracter ou substituir uma string / trocar todo caracter 'a' por 'x';
            string s6 = original.Replace('a', 'x');

            // sobrecarga de substituir um caracter ou substituir uma string / trocar toda  string 'abc' por 'xy';
            string s7 = original.Replace("abc", "xy");

            //testar se a string e nula ou vazia
            bool b1 = string.IsNullOrEmpty(original);

            //testar se a string e nula ou cheia de espaco em branco
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf ('bc'): -" + n1 + "-");
            Console.WriteLine("LastIndexOf ('bc'):  -" + s2 + "-");
            Console.WriteLine("Substring(3): -" + s4 + " - ");
            Console.WriteLine("Substring(3,5): -" + s5 + " - ");
            Console.WriteLine("Replace(troca toda 'a' por 'x'): -" + s6 + " - ");
            Console.WriteLine("Replace(troca toda string 'abc' pela string 'xy'): -" + s7 + " - ");
            Console.WriteLine("IsNullOrEmpty (testar se a variavel original esta nula ou vazia): -" + b1 + " - ");
            Console.WriteLine("IsNullOrWhiteSpace (testar se a variavel original esta nula ou cheia de espaco em branco): -" + b2 + " - ");

        }
    }
}