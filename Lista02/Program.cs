using System;

namespace Lista02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício01

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
                Console.WriteLine("Não negativo!");
            else
                Console.WriteLine("Número negativo!!");


            //Exercício02

            Console.Write("Digite um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 2 == 0)
                Console.WriteLine("Numero par!");
            else
                Console.WriteLine("Numeor impar!");


            //Exercicio03

            Console.Write("Digite o primeiro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o primeiro número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero2 % numero3 == 0 || numero3 % numero2 == 0)
                Console.WriteLine("Numeros são multiplos");
            else
                Console.WriteLine("Números não multiplos!");


            //Exercício04

            Console.Write("Digite o primeiro horário: ");
            int horario1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo horário: ");
            int horario2 = Convert.ToInt32(Console.ReadLine());

            if (horario1 < horario2)
            {
                Console.WriteLine(horario2 - horario1);
            }
            else
            {
                Console.WriteLine(24 - horario1 + horario2);
            }


            //Exercicio05

            Console.Write("Digite o código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade de intens: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            double total = 0;
            if (codigo == 1)
            {
                total = quantidade * 4;
            }

            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }

            else if (codigo == 3)
            {
                total = quantidade * 5;
            }

            else if (codigo == 4)
            {
                total = quantidade * 2;
            }

            else if (codigo == 5)
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$" + total.ToString("F4"));


            //Exercicio06

            Console.Write("Escreva um número: ");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            if (numero4 >= 0 && numero4 <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            if (numero4 > 25 && numero4 <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            if (numero4 > 55 && numero4 <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            if (numero4 > 75 && numero4 <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }


            //Exercício07

            Console.Write("Dige o primeiro numero: ");
            double numero5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dige o segundo numero: ");
            double numero6 = Convert.ToInt32(Console.ReadLine());

            if (numero5 == 0.0 && numero6 == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (numero5 == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (numero6 == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (numero5 > 0.0 && numero6 > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (numero5 < 0.0 && numero6 > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (numero5 < 0.0 && numero6 < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }


            //Exercicio08

            Console.WriteLine("Digite seu salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            if(salario <= 3000)
            {
                double resultado = (salario - 2000) * 0.08;
                Console.WriteLine("Pagar: " + resultado.ToString("F2"));
            }
            if(salario > 3000 && salario <= 4500)
            {
                double resultado = (salario - 3000) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("Pagar: " + resultado.ToString("F2"));
            }
            if(salario > 4500)
            {
                double resultado = (salario - 4500) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("Pagar: " + resultado.ToString("F2"));
            }
        }
    }
}