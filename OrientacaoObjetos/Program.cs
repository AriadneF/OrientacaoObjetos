using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01

            Console.Write("Escreva um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escreva um número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.WriteLine("SOMA: " + soma);


            //Exercicio02

            Console.Write("Valor do raio: ");
            int raio = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14159;

            double resultado = pi * (raio * raio);
            Console.WriteLine("Área do circulo: " + resultado.ToString("F4"));


            //Exercicio03

            Console.Write("Digite o primeiro valor: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o quarto valor: ");
            int d = Convert.ToInt32(Console.ReadLine());

            double operacao = (a * b) - (c * d);
            Console.WriteLine("DIFERENÇA: " + operacao);


            //Exercicio04

            Console.Write("Digite o número do funcionario: ");
            int funcionario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas pelo funcionario: ");
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor que o funcionario recebe por hora: ");
            double valorHora = Convert.ToInt32(Console.ReadLine());

            double salario = horasTrabalhadas * valorHora;
            Console.WriteLine("Código do funcionário: " + funcionario);
            Console.WriteLine("Salário do funcionário: " + salario.ToString("F2"));


            //Exercício05

            Console.Write("Digite o código do produto: ");
            int código1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de peças: ");
            int numeroPecas1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor da peça: ");
            double valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o código do produto: ");
            int código2= Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de peças: ");
            int numeroPecas2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor da peça: ");
            double valor2 = Convert.ToInt32(Console.ReadLine());

            double valorFinal = (numeroPecas1 * valor1) + (numeroPecas2 * valor2);
            Console.WriteLine("Valor a pagar: " + valorFinal);


            //Exercicio06

            Console.Write("Digite o primero valor: ");
            int letraA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int letraB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro valor");
            int letraC = Convert.ToInt32(Console.ReadLine());

            double trianguloRetangulo = (letraA * letraC) / 2;
            double circulo = pi * (letraC * letraC);
            double trapezio = (letraA + letraB) * letraC;
            double quadrado = letraB * letraB;
            double retangulo = letraA * letraB;

            Console.WriteLine("Triangulo: " + trianguloRetangulo);
            Console.WriteLine("Circulo: " + circulo);
            Console.WriteLine("Trapezio: " + trapezio);
            Console.WriteLine("Quadrado: " + quadrado);
            Console.WriteLine("Retangulo: " + retangulo);
        }
    }
}