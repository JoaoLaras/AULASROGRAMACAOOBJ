using System;
using System.IO;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = "C:\\windows\\temp\\file1.txt";
            string targetPath = "C:\\windows\\temp\\file2.txt";

            try
            {

                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // FAZ UMA COPIA DO Sourcepath para o targetpath
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                //IMPRIMIR NA TELA O ARQUIVO FILE SOURCEPATH
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
        }
    }
}