using System;

namespace Lista05Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = Convert.ToDouble(Console.ReadLine());

            double media = funcionario1.Salario + funcionario2.Salario / 2.0;

            Console.WriteLine("Salario médio: " + media.ToString("F2"));
        }
    }
}
