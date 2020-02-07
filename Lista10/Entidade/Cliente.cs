using System;

namespace Lista10.Entidade
{
    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, DateTime nascimento, string email)
        {
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", (" + Nascimento.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}