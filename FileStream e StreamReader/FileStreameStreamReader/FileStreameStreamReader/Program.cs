using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Windows\\Temp\\file1.txt";
            // FileStream fileStrem = null;
            StreamReader streamReader = null;

            try
            {
                //fileStrem = new FileStream(path, FileMode.Open);
                //  streamReader = new StreamReader(fileStrem);
                streamReader = File.OpenText(path);
                while (!streamReader.EndOfStream) // LE TODAS LINHAS ATE ACABAR O ARQUIVO
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
               /* if (fileStrem != null)
                {
                    fileStrem.Close();
                }*/
            }

        }
    }
}