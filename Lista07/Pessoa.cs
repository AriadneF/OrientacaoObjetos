using System;
using System.Collections.Generic;
using System.Text;

namespace Lista07
{
    public class Pessoa
    {
        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email; 
        }

        public string Nome;
        public string Email;
    }
}