using Course;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int s1 = Calculator.Sum(1, 2 );
            int s2 = Calculator.Sum(2, 4, 3 );
            int s3 = Calculator.Sum( 1, 2, 5, 6);
            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(result);

        }
    }
}