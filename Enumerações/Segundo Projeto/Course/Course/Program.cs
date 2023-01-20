using Course.Entidades;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comentario comentario1 = new Comentario("Tenha uma boa viagem!");
            Comentario comentario2 = new Comentario("Uau, isso é incrível");

            Postagem postagem1 = new Postagem(DateTime.Parse("21/06/2018 13:05:44"), "Viajar para Nova Zelândia!", "Eu vou visitar este país maravilhoso!",12);

            postagem1.AddComentarios(comentario1);
            postagem1.AddComentarios(comentario2);
            Console.WriteLine();

            Comentario comentario3 = new Comentario("Boa Noite");
            Comentario comentario4= new Comentario("Que a força esteja com você");
            Postagem postagem2 = new Postagem(DateTime.Parse("28/07/2018 23:14:19"), "Boa noite Galera", "Vejo você amanhã", 5);
            postagem2.AddComentarios(comentario3);
            postagem2.AddComentarios(comentario4);

            Console.WriteLine(postagem1);
            Console.WriteLine(postagem2);
        }
    }
}