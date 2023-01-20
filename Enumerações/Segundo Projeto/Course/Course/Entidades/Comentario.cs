using System;


namespace Course.Entidades
{
    internal class Comentario
    {
        public string Text { get; set; }

        public Comentario() { }

        public Comentario(string text)
        {
            Text = text;
        }
    }
}
