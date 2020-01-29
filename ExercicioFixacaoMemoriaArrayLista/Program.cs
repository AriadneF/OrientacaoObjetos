using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioFixacaoMemoriaArrayLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaA = new List<int>();
            List<int> listaB = new List<int>();
            List<int> listaC = new List<int>();

            Console.Write("Digite a quantidade de alunos da turma a: ");
            int alunosA = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < alunosA; i++)
            {
                Console.Write("Digite o código do aluno: ");
                int codigoAlunoA = Convert.ToInt32(Console.ReadLine());
                listaA.Add(codigoAlunoA);
            }

            Console.Write("Digite a quantidade de alunos da turma b: ");
            int alunosB = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < alunosB; i++)
            {
                Console.Write("Digite o código do aluno: ");
                int codigoAlunoB = Convert.ToInt32(Console.ReadLine());
                listaB.Add(codigoAlunoB);
            }

            Console.Write("Digite a quantidade de alunos da turma c: ");
            int alunosC = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < alunosC; i++)
            {
                Console.Write("Digite o código do aluno: ");
                int codigoAlunoC = Convert.ToInt32(Console.ReadLine());
                listaC.Add(codigoAlunoC);
            }

            var alunos = listaA.Union(listaB);
            alunos = alunos.Union(listaC);
            Console.WriteLine("Total de Alunos: " + alunos.Count());
        }
    }
}