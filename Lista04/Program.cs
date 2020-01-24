using System;

namespace Lista04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01

            Console.Write("Digite um número: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


            //Exercício02

            Console.WriteLine("");
            Console.Write("Digite o numero: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= valor; i++)
            {
                if (i >= 10 && i <= 20)
                {

                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine("In: " + dentro);
            Console.WriteLine("Out: " + fora);
            Console.WriteLine("MUITO OBRIGADO!");


            //Exercicio03

            Console.WriteLine("");
            Console.Write("Digite a quantidade: ");
            int valorN = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= valorN; i++)
            {
                Console.Write("Digite os números: ");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1"));
            }


            //Exercício04

            Console.WriteLine("");
            Console.Write("Digite o valor: ");
            int numeroN = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= numeroN; i++)
            {
                Console.Write("Digite o par de numeros: ");
                double d = Convert.ToDouble(Console.ReadLine());
                double e = Convert.ToDouble(Console.ReadLine());

                double divisao = d / e;
                if(e <= 0)
                {
                    Console.WriteLine("divisao impossivel");
                }

                Console.WriteLine(divisao);
            }


            //Exercício05

            Console.WriteLine("");
            Console.Write("Digite o valor: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;

            for(int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            Console.WriteLine("Fatorial: " + resultado);


            //Exercício06

            Console.WriteLine("");
            Console.Write("Digite o valor: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= numero1; i++)
            {
                if(numero1 % i == 0)
                {
                    Console.WriteLine(i);
                }
            }


            //Exercício07

            Console.WriteLine("");
            Console.Write("Digite o valor: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= numero2; i++)
            {
                int a = i;
                int b = i * i;
                int c = i * i * i;

                Console.WriteLine(a + " " + b+ " " + c);
            }
        }
    }
}