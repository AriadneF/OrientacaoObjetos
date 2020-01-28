using System;

namespace Lista09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de linhas e após o de colunas: ");
            string[] posicoes = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(posicoes[0]);
            int n = Convert.ToInt32(posicoes[1]);

            int[,] matriz = new int[m, n];

            Console.WriteLine("Digite os valores das variaves, separados unicamente por espaço: ");
            for(int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for(int o = 0; o < n; o++)
                {
                    matriz[i, o] = Convert.ToInt32(valores[o]);
                }
            }

            Console.Write("Valor a ser procurado: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int o = 0; o < n; o++)
                {
                    if(matriz[i,o] == valor)
                    {
                        Console.WriteLine("Posição: " + i + "; " + o + ": ");
                        if(o > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, o - 1]);
                        }
                        if(i < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, o + 1]);
                        }
                        if( o < m - 1)
                        {
                            Console.WriteLine("Embaixo: " + matriz[i + 1, o]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Em cima: " + matriz[i, o + 1]);
                        }
                    }
                }
            }
        }       
    }
}