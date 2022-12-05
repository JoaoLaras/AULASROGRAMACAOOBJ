namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Joao", "Nathalia", "Giovana" };

            /* USANDO LACO FOR
            for (int i = 0; i <vect.Length; i ++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("**************************");*/
            // USANDO LACO FOREACH
            foreach (string nome in vect)
            {
                Console.Write(nome);
            }
        }
    }
}