using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   //BOXING
            int x = 20;
            // stack - x = 20
            Object obj = x;
            Console.WriteLine(obj);
            // obj -----> 20 - heap
            string s = "Joao";
            Object obj2 = s;
            Console.WriteLine(obj2);

            //UNBOXING
            // stack - y = 20;
            int y = (int) obj;
            Console.WriteLine(y);
            //stack - s1 = "Joao";
            string s1 = (string)obj2;
            Console.WriteLine(s1);
        }
    }
}