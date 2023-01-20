using System;
using System.Text;

namespace Course.Entidades
{
    internal class Postagem
    {
        public DateTime Momento { get; set; }
        public String Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Postagem() { }

        public Postagem(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;

        }

        public void AddComentarios(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoveComentarios(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss "));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários:");
            foreach (Comentario comentario in Comentarios)
            {
                sb.AppendLine(comentario.Text);
            }

            return sb.ToString();

        }
    }
}
