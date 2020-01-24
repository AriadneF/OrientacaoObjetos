using System;

namespace Lista07
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] estudante = new Pessoa[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int aluguel = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= aluguel; i++)
            {
                Console.WriteLine("Cadastro de aluguel!");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = Convert.ToInt32(Console.ReadLine());
                estudante[quarto] = new Pessoa(nome, email);
            }

            Console.WriteLine("Quartso alugados: ");
            for(int i = 1; i <= aluguel; i++)
            {
                if(estudante[i] != null)
                {
                    Console.WriteLine(i + ": " + estudante[i]);
                }
            }
        }
    }
}