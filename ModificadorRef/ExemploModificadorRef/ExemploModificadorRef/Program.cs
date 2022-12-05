using ExemploModificadorRef;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   //COM REF = 30;
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            // SEM REF = 10;

            int aB = 10;
            Calculator.Triple1(aB);
            Console.WriteLine(aB);
        }
    }
}