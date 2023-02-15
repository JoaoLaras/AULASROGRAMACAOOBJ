using System;
using System.IO;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Windows\Temp\file1.txt";
            string targetPath = @"C:\Windows\Temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                        

                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("error!!!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}