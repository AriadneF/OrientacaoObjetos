using System;

namespace Lista06
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            double quantia; 

            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Numero da conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Será feito deposito(sim/nao)? ");
            string aceito = Console.ReadLine();
            if(aceito == "sim")
            {
                Console.Write("Qual será o valor? ");
                double valor = Convert.ToDouble(Console.ReadLine());
                conta = new Conta(numero, titular, valor);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Qual valor será depositado? ");
            quantia = Convert.ToDouble(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Qual valor será depositado? ");
            quantia = Convert.ToDouble(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }
    }
}