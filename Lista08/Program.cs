using System;
using System.Collections.Generic;

namespace Lista08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios receberão aumento? ");
            int funcionarios = Convert.ToInt32(Console.ReadLine());

            List<Aumento> aumentos = new List<Aumento>();

            for (int i = 1; i <= funcionarios; i++)
            {
                Console.Write("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = Convert.ToInt32(Console.ReadLine());
                aumentos.Add(new Aumento(id, nome, salario));
            }

            Console.Write("Id do funcionario que receberá o aumento: ");
            int idAumento = Convert.ToInt32(Console.ReadLine());

            Aumento aumento = aumentos.Find(x => x.Id == idAumento);
            if (aumento != null)
            {
                Console.Write("Porcentagem: ");
                int porcentagem = Convert.ToInt32(Console.ReadLine());
                aumento.AumentoSalario(porcentagem);

                Console.WriteLine("Informações atualizadas:");
                foreach (Aumento itens in aumentos)
                {
                    Console.WriteLine(itens);
                }
            }
            else
            {
                Console.WriteLine("Id não encontrado");
            }            
        }
    }
}