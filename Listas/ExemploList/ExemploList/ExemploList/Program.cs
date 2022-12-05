namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list;
            list = new List<string>();

            //Add um elemento em sua lista

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Arthur");

            //adiciona um elemento na posicao
            list.Insert(2, "Marco");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Mostrar tamanho da lista
            Console.WriteLine("Tamanho da lista: " + list.Count);

            //Expressão Lambida, Primeiro nome com A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com Inicial 'A' = " + s1);


            //Expressão Lambida, Ultimo nome com A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome com Inicial 'A' = " + s2);

            //Expressão Lambida, Primeira Posicao como nome A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com 'A', na posição = " + pos1);

            //Expressão Lambida, Ultima Posicao como nome A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome com 'A', na posição = " + pos2);
            Console.WriteLine("----------------------------------------");
            //Expressão Lambida, filtrar lista por tamanho
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("Lista filtrada por tamanho com 5 caractere cada elemento");
            foreach (string obj1 in list2)
            {
                Console.WriteLine(obj1);
            }

            Console.WriteLine("------------------------------------------------");

            //Expressão Lambida, remover da lista
            list.Remove("Arthur");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Expressão Lambida, remover da lista
            Console.WriteLine("------------------------------------------------");
            list2.Remove("Marco");
            foreach (string obj2 in list2)
            {
                Console.WriteLine(obj2);
            }

            //Expressão Lambida, remover da lista por Predicado 'M'
            Console.WriteLine("------------------------------------------------");
            list2.RemoveAll(x => x[0] == 'M');
            foreach (string obj2 in list2)
            {
                Console.WriteLine(obj2);
            }

            //Expressão Lambida, remover da lista por Predicado 'M'
            Console.WriteLine("------------------------------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj1 in list)
            {
                Console.WriteLine(obj1);
            }

            Console.WriteLine("------------------------------------------------");


            List<string> list3;
            list3 = new List<string>();

            list3.Add("Maria");
            list3.Add("Alex");
            list3.Add("Bob");
            list3.Add("Anna");
            list3.Add("Arthur");

            Console.WriteLine("Lista 3 ");
            foreach (string obj2 in list3)
            {
                Console.WriteLine(obj2);
            }
            Console.WriteLine("------------------------------------------------");

            //Expressão Lambida, remover da lista por Posicao '2'
            list3.RemoveAt(2);
            foreach (string obj2 in list3)
            {
                Console.WriteLine(obj2);
            }

            Console.WriteLine("------------------------------------------------");
            //Expressão Lambida, remover elementos de uma faixa
            list3.RemoveRange(0, 3);
            Console.WriteLine("Remover de da posicao zero, contando 3 pessoas = ");
            foreach (string obj2 in list3)
            {
                Console.WriteLine(obj2);
            }



        }
        /* FUNCAO TESTE BOOL
        static bool Test(string s)
        {
            return s[0] == 'A';
        }*/
    }
}