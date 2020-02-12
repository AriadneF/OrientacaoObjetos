using Exercicio11.Entidades;
using System;
using System.Collections.Generic;

namespace Exercicio11
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            Console.Write("Quantidade de produtos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine("Produto" + i + " data:");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char tipo = Convert.ToChar(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preco: ");
                double preco = Convert.ToDouble(Console.ReadLine());

                if (tipo == 'c')
                {
                    lista.Add(new Produto(nome, preco));
                }
                else if (tipo == 'u')
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, data));
                }
                else
                {
                    Console.Write("Taxas: ");
                    double taxas = Convert.ToDouble(Console.ReadLine());
                    lista.Add(new ProdutoImportado(nome, preco, taxas));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiqueta:");
            foreach (Produto prod in lista)
            {
                Console.WriteLine(prod.Etiqueta());
            }
        }
    }
}