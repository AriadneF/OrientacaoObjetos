using System;

namespace Exercicio11.Entidades
{
    public class ProdutoUsado : Produto
    {
        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Fabricacao = fabricacao;
        }

        public override string Etiqueta()
        {
            return Nome + " (usado) $ " + Preco.ToString("F2") + " (Data de fabricação: " + Fabricacao.ToString("dd/MM/yyyy") + ")";
        }

        public DateTime Fabricacao { get; set; }
    }
}