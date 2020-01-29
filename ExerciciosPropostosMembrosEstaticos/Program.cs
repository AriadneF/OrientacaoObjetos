using System;

namespace ExerciciosPropostosMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cotação do dólar no momento: ");
            double cotacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinheiro a ser comprado: ");
            double compra = Convert.ToInt32(Console.ReadLine());

            double resultado = Conversao.Converte(cotacao, compra);
            Console.WriteLine("Valor a ser pago: " + resultado.ToString("F2"));
        }
    }
}