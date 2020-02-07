using Lista10.Entidade;
using Lista10.Entidade.Enum;
using System;
using System.Globalization;

namespace Lista10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o email: ");
            string email = Console.ReadLine();
            Console.Write("Digite a data de nascimento (dia/mês/ano): ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Status do pedido: ");
            Status status = Enum.Parse<Status>(Console.ReadLine());

            Cliente cliente = new Cliente(nome, nascimento, email);
            Pedido pedido = new Pedido(DateTime.Today, status, cliente);

            Console.Write("Quantidade de itens: ");
            int itens = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itens; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string produtoNome = Console.ReadLine();
                Console.Write("Product price: ");
                double preco = double.Parse(Console.ReadLine());

                Produto produto = new Produto(produtoNome, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItemPedido pedir = new ItemPedido(quantidade, preco, produto);

                pedido.AddItem(pedir);
            }

            Console.WriteLine();
            Console.WriteLine("Pedido:");
            Console.WriteLine(pedido);
        }
    }
}