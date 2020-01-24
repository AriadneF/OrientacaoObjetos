using System;

namespace Lista03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício01

            Console.Write("Digite a senha numerica: ");
            int senha = Convert.ToInt32(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida!");
                Console.Write("Digite a senha numerica: ");
                senha = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!");


            //Exercício02

            Console.Write("Digite a primeira coordenada: ");
            int coordenada1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a segunda coordenada: ");
            int coordenada2 = Convert.ToInt32(Console.ReadLine());

            while (coordenada1 != 0 && coordenada2 != 0)
            {
                if (coordenada1 > 0 && coordenada2 > 0)
                {
                    Console.WriteLine("primeiro");
                    break;
                }
                else if (coordenada1 < 0 && coordenada2 > 0)
                {
                    Console.WriteLine("segundo");
                    break;
                }
                else if (coordenada1 < 0 && coordenada2 < 0)
                {
                    Console.WriteLine("terceiro");
                    break;
                }
                else
                {
                    Console.WriteLine("quarto");
                    break;
                }
            }


            //Exercício03

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("Produtos: ");
            int produto = int.Parse(Console.ReadLine());

            while (produto != 4)
            {
                if (produto == 1)
                {
                    alcool += 1;
                }
                else if (produto == 2)
                {
                    gasolina += 1;
                }
                else if (produto == 3)
                {
                    diesel +=  1;
                }

                produto = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);                    
            Console.WriteLine("MUITO OBRIGADO!");
        }
    }
}