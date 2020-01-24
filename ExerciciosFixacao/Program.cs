using System;

namespace ExerciciosFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Largura: ");
            retangulo.Largura = Convert.ToDouble(Console.ReadLine());

            double area = retangulo.Largura * retangulo.Altura;
            double perimetro = retangulo.Altura + retangulo.Altura + retangulo.Largura + retangulo.Largura;
            double diagonal = Math.Sqrt((retangulo.Largura * retangulo.Largura) + (retangulo.Altura * retangulo.Altura));

            Console.WriteLine("Área: " + area.ToString("F2"));
            Console.WriteLine("Perímetro: " + perimetro.ToString("F2"));
            Console.WriteLine("Diagonal: " + diagonal.ToString("F2"));
        }
    }
}