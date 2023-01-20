using System;


namespace Course.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime Date { get; set; }

        public Cliente() { }

        public Cliente(string nome, string email, DateTime date)
        {
            Nome = nome;
            Email = email;
            Date = date;
        }

        public override string ToString()
        {
            return Nome
                + ", (" + Date.ToString("dd/MM/yyyy") + ") - "
                + Email;
        }


    }
}
