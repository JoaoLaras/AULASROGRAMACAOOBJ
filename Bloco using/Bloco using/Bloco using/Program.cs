using System;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Windows\\Temp\\file1.txt";

            try
            {   //BLOCO USING NAO PRECISA FECHAR OBJETOS //FINNALLY
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!");
                Console.WriteLine(e.Message);
            }

        }
    }
}