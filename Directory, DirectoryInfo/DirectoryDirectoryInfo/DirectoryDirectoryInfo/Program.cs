

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LISTAR AS SUBPASTAS A PARTIR DE UMA PASTA INFORMADA
            string path = "C:\\Windows\\Temp\\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (var folder in folders)
                {
                    Console.WriteLine(folder);
                }

                //LISTAR TODOS ARQUIVOS A PARTIR DE UMA PASTA INFORMADA
                Console.WriteLine("***********************************************************************");
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                //CRIAR UMA PASTA NEWFOLDER A PARTIR DA PASTA myfolder
                Directory.CreateDirectory(path + "\\novapasta");
                //CRIAR UMA PASTA NEWFOLDER A PARTIR DA NOVAPASTA
                Directory.CreateDirectory("C:\\Windows\\Temp\\myfolder\\novapasta\\novapasta123\\ultimapasta");
            }

            catch (Exception e)
            {
                Console.WriteLine("ERROR!!");
                Console.WriteLine(e.Message);
            }

        }
    }
}