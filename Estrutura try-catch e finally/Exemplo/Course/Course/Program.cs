﻿using System;
using System.Reflection.Metadata;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());

                int n2 = int.Parse(Console.ReadLine());

                int n3 = n1 / n2;
                Console.WriteLine(n3);



            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }

            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }



        }
    }
}
